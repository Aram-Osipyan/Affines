using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace Affine
{
    public class Polygon
    {
        public List<Point> Points { get; }
        public Point Center { get; set; } = new Point(0, 0, 0);
        public Point PolyhedronCenter { get; set; }
        public Point Normal
        {
            get
            {
                // vector product
                Point first = Points[0],
                    second = Points[1],
                    third = Points[2];
                var A = first.Y * (second.Z - third.Z) + second.Y * (third.Z - first.Z) + third.Y * (first.Z - second.Z);
                var B = first.Z * (second.X - third.X) + second.Z * (third.X - first.X) + third.Z * (first.X - second.X);
                var C = first.X * (second.Y - third.Y) + second.X * (third.Y - first.Y) + third.X * (first.Y - second.Y);

                Point vecMul = new Point(A, B, C);

                Point SC = new Point(second.X - PolyhedronCenter.X, second.Y - PolyhedronCenter.Y, second.Z - PolyhedronCenter.Z);
                if (Point.ScalarProduct(vecMul, SC) > 1E-6)
                {
                    vecMul.X *= -1;
                    vecMul.Y *= -1;
                    vecMul.Z *= -1;
                }
                return vecMul;

            }
        }
        //public bool IsVisible { get; set; }
        public Polygon(Polygon face)
        {
            Points = face.Points.Select(pt => new Point(pt.X, pt.Y, pt.Z)).ToList();
            Center = new Point(face.Center);
        }

        
        public Polygon(List<Point> pts = null)
        {
            if (pts != null)
            {
                Points = new List<Point>(pts);
                UpdateCenter();
            }
        }

        private void UpdateCenter()
        {
            Center.X = 0;
            Center.Y = 0;
            Center.Z = 0;
            foreach (Point p in Points)
            {
                Center.X += p.X;
                Center.Y += p.Y;
                Center.Z += p.Z;
            }
            Center.X /= Points.Count;
            Center.Y /= Points.Count;
            Center.Z /= Points.Count;
        }
        public List<PointF> make_perspective(float k = 1000, float z_camera = 1000)
        {
            List<PointF> res = new List<PointF>();

            foreach (Point p in Points)
            {
                res.Add(p.make_perspective(k));
            }
            return res;
        }

        public List<PointF> make_isometric()
        {
            List<PointF> res = new List<PointF>();

            foreach (Point p in Points)
                res.Add(p.make_isometric());

            return res;
        }

        public List<PointF> make_orthographic(Axis a)
        {
            List<PointF> res = new List<PointF>();

            foreach (Point p in Points)
                res.Add(p.make_orthographic(a));

            return res;
        }
        public void DrawByCamera(Graphics g,Camera camera,Pen pen = null)
        {
            if (pen == null)
                pen = Pens.Black;
            List<PointF> pts = new List<PointF>();

            foreach (Point p in Points)
                pts.Add(camera.PointImage(p));

            if (pts.Count > 1)
            {
                g.DrawLines(pen, pts.ToArray());
                g.DrawLine(pen, pts[0], pts[pts.Count - 1]);
            }
            else if (pts.Count == 1)
                g.DrawRectangle(pen, pts[0].X, pts[0].Y, 1, 1);
        }
        public void Show(Graphics g, Projection pr = 0, Pen pen = null)
        {
            if (pen == null)
                pen = Pens.Black;

            List<PointF> pts;

            IsVisible(Center, new Edge(new Point(0, 0, 500), new Point(0, 0, 500)));

            switch (pr)
            {
                case Projection.ISOMETRIC:
                    pts = make_isometric();
                    break;
                case Projection.ORTHOGR_X:
                    pts = make_orthographic(Axis.AXIS_X);
                    break;
                case Projection.ORTHOGR_Y:
                    pts = make_orthographic(Axis.AXIS_Y);
                    break;
                case Projection.ORTHOGR_Z:
                    pts = make_orthographic(Axis.AXIS_Z);
                    break;
                default:
                    pts = make_perspective(1000);
                    break;
            }

            if (pts.Count > 1)
            {
                g.DrawLines(pen, pts.ToArray());
                g.DrawLine(pen, pts[0], pts[pts.Count - 1]);
            }
            else if (pts.Count == 1)
                g.DrawRectangle(pen, pts[0].X, pts[0].Y, 1, 1);

        }
        
        public void translate(float x, float y, float z)
        {
            foreach (Point p in Points)
                p.Translate(x, y, z);
            UpdateCenter();
        }

        public void rotate(double angle, Axis a, Edge line = null)
        {
            foreach (Point p in Points)
                p.rotate(angle, a, line);
            UpdateCenter();
        }

        public void scale(float kx, float ky, float kz)
        {
            foreach (Point p in Points)
                p.Scale(kx, ky, kz);
            UpdateCenter();
        }

        public bool IsVisible(Point pCenter, Edge camera)
        {
            PolyhedronCenter = pCenter;

            Point P = camera.First;
            Point E = new Point(P.X - Center.X, P.Y - Center.Y, P.Z - Center.Z);

            double angle = Math.Acos(Point.ScalarProduct(Normal, E)
                / (Normal.VectorDistance() * E.VectorDistance()));
            angle = angle * 180 / Math.PI;

            return  angle >= 90;
        }
        public bool IsVisible(Camera camera)
        {     
            double angle = Math.Acos(Point.ScalarProduct(Normal, camera.ViewDirection)
                / (Normal.VectorDistance() * camera.ViewDirection.VectorDistance()));
            angle = angle * 180 / Math.PI;

            return angle >= 90;
        }
    }
}
