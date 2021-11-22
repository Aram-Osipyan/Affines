using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DAfines
{
    public class Point
    {
        public float X { set; get; }
        public float Y { set; get; }
        public float Z { set; get; }
        public Point(float x, float y,float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point(double x, double y, double z)
        {
            X = (float)x;
            Y = (float)y;
            Z = (float)z;
        }
        public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point Normalize()
        {
            float distance = (float)Math.Sqrt(X * X + Y * Y+Z*Z);
            return new Point(X / distance, Y / distance,Z/distance);
        }
        public Matrix GetMatrix()
        {
            return new float[,] { { X, Y,Z, 1 } };
        }
        public void Translate(float dx, float dy, float dz)
        {
            Matrix a = GetMatrix();
            Matrix res = a * Matrix.AfineTranslate(dx, dy,dz);
            X = res[0, 0];
            Y = res[0, 1];
            Z = res[0, 2];
        }
        public void Rotate(float ax, float ay, float az)
        {
            Matrix a = GetMatrix();
            Matrix res = a *
                Matrix.AfineRotateX(ax) *
                Matrix.AfineRotateY(ay)*                
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
        public void LineRotate(Point vec,float angle)
        {
            Matrix a = GetMatrix();
            Matrix res = a *
                Matrix.LineRotate(vec, angle);
            X = res[0, 0];
            Y = res[0, 1];
            Z = res[0, 2];
        }
        public void ReflectionYZ()
        {
            Matrix a = GetMatrix();
            Matrix res = a * Matrix.ReflectYZ();
            X = res[0, 0];
            Y = res[0, 1];
            Z = res[0, 2];

        }

        public void ReflectionZX()
        {
            Matrix a = GetMatrix();
            Matrix res = a * Matrix.ReflectZX();
            X = res[0, 0];
            Y = res[0, 1];
            Z = res[0, 2];
        }

        public void ReflectionXY()
        {
            Matrix a = GetMatrix();
            Matrix res = a * Matrix.ReflectXY();
            X = res[0, 0];
            Y = res[0, 1];
            Z = res[0, 2];
        }
        public static Point iso3Dto2D(Point p, int width = 100, int height = 100, float phi = 145, float xi = 45)
        {

            float radPhi = phi * (float)Math.PI / 180;
            float radXi = xi * (float)Math.PI / 180;

            Matrix m2 = new float[,]{
                { (float)Math.Cos(radXi), 0, -(float)Math.Sin(radXi), 0},
                { 0, 1, 0, 0},
                { (float)Math.Sin(radXi), 0, (float)Math.Cos(radXi), 0},
                {0, 0, 0, 1 } };
            Matrix m1 = new float[,]{
                { 1, 0, 0, 0},
                { 0, (float)Math.Cos(radPhi), (float)Math.Sin(radPhi) , 0},
                { 0, -(float)Math.Sin(radPhi), (float)Math.Cos(radPhi), 0},
                {0, 0, 0, 1 } };

            Matrix iso_matr = m1*m2;
            Matrix point = new float[,] { { p.X }, { p.Y }, { p.Z }, { 1 } };
            Matrix c = iso_matr*point;
            return new Point(width / 2 + (int)c[0, 0], height / 2 + (int)c[1, 0],0);
        }
        public Point Copy()
        {
            return new Point(X, Y, Z);
        }
    }
  
    
}
