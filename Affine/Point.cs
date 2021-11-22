using System;
using System.Collections.Generic;
using System.Drawing;

namespace Affine
{
    public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }


        public Point(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Z = p.Z;
        }


        public Matrix GetMatrix()
        {
            return new float[,] { { X, Y, Z, 1 } };
        }
        public void Translate(float dx, float dy, float dz)
        {
            Matrix a = GetMatrix();
            Matrix res = a * Matrix.AfineTranslate(dx, dy, dz);
            X = res[0, 0];
            Y = res[0, 1];
            Z = res[0, 2];
        }
        public void Rotate(float ax, float ay, float az)
        {
            Matrix a = GetMatrix();
            Matrix res = a *
                Matrix.AfineRotateX(ax) *
                Matrix.AfineRotateY(ay) *
                Matrix.AfineRotateZ(az);
            X = res[0, 0];
            Y = res[0, 1];
            Z = res[0, 2];
        }

        public void Scale(float alpha, float beta, float gamma)
        {
            Matrix a = GetMatrix();
            Matrix res = a *
                Matrix.Scale(alpha, beta, gamma);
            X = res[0, 0];
            Y = res[0, 1];
            Z = res[0, 2];
        }
        public PointF make_perspective(float k = 1000)
        {
            if (Math.Abs(Z - k) < 1e-10)
                k += 1;

            Matrix P = new float[,] { {1, 0, 0, 0 },
                                              { 0, 1, 0, 0 },
                                              { 0, 0, 0, -1/k },
                                              { 0, 0, 0, 1 } };

            Matrix xyz = GetMatrix();
            Matrix c = xyz * P;// mul_matrix(xyz, 1, 4, P, 4, 4);

            return new PointF(c[0, 0] / c[0, 3], c[0, 1] / c[0, 3]);
        }

        public PointF make_isometric()
        {
            double r_phi = Math.Asin(Math.Tan(Math.PI * 30 / 180));
            double r_psi = Math.PI * 45 / 180;
            float cos_phi = (float)Math.Cos(r_phi);
            float sin_phi = (float)Math.Sin(r_phi);
            float cos_psi = (float)Math.Cos(r_psi);
            float sin_psi = (float)Math.Sin(r_psi);

            Matrix M = new float[,] { {cos_psi, sin_phi * sin_psi, 0, 0 },
                                    { 0,cos_phi,0,  0 },
                                    { sin_psi,  -sin_phi * cos_psi,  0,  0 },
                                    { 0,0,0, 1 } };

            Matrix xyz = GetMatrix();
            Matrix c = xyz * M;//mul_matrix(xyz, 1, 4, M, 4, 4);

            return new PointF(c[0, 0], c[0, 1]);
        }

        public PointF make_orthographic(Axis a)
        {
            Matrix P = new float[,] {
            {1,0,0,0 },
            {0,1,0,0 },
            {0,0,1,0 },
            {0,0,0,1 },
            };

            if (a == Axis.AXIS_X)
                P[0, 0] = 0;
            else if (a == Axis.AXIS_Y)
                P[0, 1] = 0;
            else
                P[0, 2] = 0;

            Matrix xyz = GetMatrix();
            Matrix c = xyz * P;// mul_matrix(xyz, 1, 4, P, 4, 4);

            if (a == Axis.AXIS_X)
                return new PointF(c[0, 1], c[0, 2]);
            else if (a == Axis.AXIS_Y)
                return new PointF(c[0, 0], c[0, 2]);
            else
                return new PointF(c[0, 0], c[0, 1]);
        }
        /*----------------------------- Affine transformations -----------------------------*/


        public static float ScalarProduct(Point p1, Point p2)
        {
            return p1.X * p2.X + p2.Y * p1.Y + p1.Z * p2.Z;
        }
        public float VectorDistance()
        {
            return (float)Math.Sqrt((double)(X * X + Y * Y + Z * Z));
        }


        public void rotate(double angle, Axis a, Edge line = null)
        {
            double rangle = Math.PI * angle / 180;

            Matrix R = null;

            float sin = (float)Math.Sin(rangle);
            float cos = (float)Math.Cos(rangle);
            switch (a)
            {
                case Axis.AXIS_X:
                    R = new float[,] { {1,   0,     0,   0 },
                                          { 0,  cos,   sin,  0 },
                                          { 0,  -sin,  cos,  0 },
                                          { 0,   0,     0,   1 } };
                    break;
                case Axis.AXIS_Y:
                    R = new float[,] { {cos,  0,  -sin,  0 },
                                           { 0,   1,   0,    0 },
                                          { sin,  0,  cos,   0 },
                                           { 0,   0,   0,    1 } };
                    break;
                case Axis.AXIS_Z:
                    R = new float[,] { {cos,   sin,  0,  0 },
                                         { -sin,  cos,  0,  0 },
                                         {  0,     0,   1,  0 },
                                          { 0,     0,   0,  1 } };
                    break;
                case Axis.LINE:
                    float l = Math.Sign(line.Second.X - line.First.X);
                    float m = Math.Sign(line.Second.Y - line.First.Y);
                    float n = Math.Sign(line.Second.Z - line.First.Z);
                    float length = (float)Math.Sqrt(l * l + m * m + n * n);
                    l /= length; m /= length; n /= length;

                    R = new float[,] {  {l * l + cos * (1 - l * l),   l * (1 - cos) * m + n * sin,   l * (1 - cos) * n - m * sin,  0 },
                                          { l * (1 - cos) * m - n * sin,   m * m + cos * (1 - m * m),    m * (1 - cos) * n + l * sin,  0 },
                                          { l * (1 - cos) * n + m * sin,  m * (1 - cos) * n - l * sin,    n* n +cos * (1 - n * n),   0},
                                           {            0,                            0,                             0,               1 } };

                    break;
            }
            Matrix xyz = GetMatrix();
            Matrix c = xyz*R;

            X = c[0,0];
            Y = c[0,1];
            Z = c[0,2];
        }
        public Point Copy()
        {
            return new Point(X, Y, Z);
        }
        public void Normalize()
        {
            float p = (float)Math.Sqrt(X * X + Y * Y + Z * Z);
            X /= p;
            Y /= p;
            Z /= p;
        }
        public static Point operator-(Point p1,Point p2)
        {
            Point p = new Point(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
            return p;
        }
        public void SetValues(float x,float y,float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return X + " " + Y + " " + Z;
        }

    }
}
