using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DAfines
{
    public class Matrix
    {
        private readonly float[,] _data;
        public int N
        {
            get
            {
                return _data.GetUpperBound(0) + 1;
            }
        }
        public int M
        {
            get
            {
                return _data.GetUpperBound(1) + 1;
            }
        }

        public Matrix(int n)
        {
            _data = new float[n, n];
            for (int i = 0; i < n; i++)
            {
                _data[i, i] = 1.0f;
            }
        }
        public Matrix(int m, int n)
        {
            _data = new float[m, n];
        }

        public Matrix(float[,] data)
        {
            _data = data;
        }

        public ref float this[int row, int column] => ref _data[row, column];

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.M != b.N)
            {
                return null;
            }
            Matrix c = new Matrix(a.N, b.M);
            for (int i = 0; i < c.N; i++)
            {
                for (int j = 0; j < c.M; j++)
                {
                    float sum = 0;
                    for (int m = 0; m < a.M; m++)
                    {
                        sum += a[i, m] * b[m, j];
                    }
                    c[i, j] = sum;
                }
            }
            return c;
        }
        public static implicit operator Matrix(float[,] matrix)
        {
            return new Matrix(matrix);
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.M != b.M || a.N != b.N)
            {
                return null;
            }
            Matrix c = new Matrix(a.N, b.M);
            for (int i = 0; i < c.N; i++)
            {
                for (int j = 0; j < c.M; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            return c;
        }
        public static Matrix AfineTranslate(float dx, float dy,float dz)
        {
            Matrix data = new float[,]
            {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { dx, dy, dz, 1 },
            };
            return data;
        }
        public static Matrix AfineRotateX(float angle)
        {
            float phi = angle * (float)Math.PI / 180;
            float cos = (float)Math.Cos(phi);
            float sin = (float)Math.Sin(phi);
            return new float[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, cos, -sin, 0 },
                    { 0, sin, cos, 0 },
                    { 0, 0, 0, 1 }
                };
        }
        public static Matrix AfineRotateY(float angle)
        {
            float phi = angle * (float)Math.PI / 180;
            float cos = (float)Math.Cos(phi);
            float sin = (float)Math.Sin(phi);
            return new float[,]
                {
                    { cos, 0, sin, 0 },
                    { 0, 1, 0, 0 },
                    { -sin, 0, cos, 0 },
                    { 0, 0, 0, 1 }
                };
        }
        public static Matrix AfineRotateZ(float angle)
        {
            float phi = angle * (float)Math.PI / 180;
            float cos = (float)Math.Cos(phi);
            float sin = (float)Math.Sin(phi);
            return new float[,]
                {
                    { cos, -sin, 0, 0 },
                    { sin, cos, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 }
                };
        }
        public static Matrix Scale(float alpha, float beta, float gamma)
        {
            return new float[,]
                {
                { alpha, 0, 0, 0 },
                { 0, beta, 0, 0 },
                { 0, 0, gamma, 0 },
                { 0, 0, 0, 1 } };
        }
        public static Matrix AfineScaleMatrix(float coef, float a, float b)
        {
            float[,] affinMatr = new float[3, 3];
            affinMatr[0, 0] = coef;
            affinMatr[0, 1] = 0;
            affinMatr[0, 2] = 0;
            affinMatr[1, 0] = 0;
            affinMatr[1, 1] = coef;
            affinMatr[1, 2] = 0;
            affinMatr[2, 0] = (1 - coef) * a;
            affinMatr[2, 1] = (1 - coef) * b;
            affinMatr[2, 2] = 1;
            return new Matrix(affinMatr);
        }
    }
}
