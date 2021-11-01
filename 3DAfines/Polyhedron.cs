using System;
using System.Collections.Generic;
using System.Drawing;

namespace _3DAfines
{
    class Polyhedron
    {
        private List<Point> _points;
        private List<Edge> _edges;
        public List<Edge> Edges
        {
            get
            {
                return _edges;
            }
        }
        public Polyhedron(List<Point> points, List<Edge> edges)
        {
            _points = points;
            _edges = edges;
        }
        public Polyhedron()
        {
            _points = new List<Point>();
            _edges = new List<Edge>();
        }
        public void DrawParall(Graphics graphics,Pen pen)
        {
            foreach (var item in _edges)
            {
                item.DrawParall(graphics, pen);
            }
        }
        public void DrawIso(Graphics graphics, Pen pen)
        {
            foreach (var item in _edges)
            {
                item.DrawIso(graphics, pen);
            }
        }
        public void Translate(float dx, float dy, float dz)
        {
            foreach (var item in _points)
            {
                item.Translate(dx, dy, dz);
            }
        }
        public void Rotate(float ax, float ay, float az)
        {
            foreach (var item in _points)
            {
                item.Rotate(ax, ay, az);
            }
        }
        public void Scale(float ax, float ay, float az)
        {
            foreach (var item in _points)
            {
                item.Scale(ax, ay, az);
            }
        }
        public static Polyhedron Hexahedron(float size)
        {
            Polyhedron ans = new Polyhedron();
            ans._points.Add(new Point(0, 0, 0));
            ans._points.Add(new Point(0, size, 0));
            ans._points.Add(new Point(size, size, 0));
            ans._points.Add(new Point(size, 0, 0));

            ans._points.Add(new Point(0, 0, size));
            ans._points.Add(new Point(0, size, size));
            ans._points.Add(new Point(size, size, size));
            ans._points.Add(new Point(size, 0, size));

            ans._edges.Add(new Edge(ans._points[0], ans._points[1]));
            ans._edges.Add(new Edge(ans._points[1], ans._points[2]));
            ans._edges.Add(new Edge(ans._points[2], ans._points[3]));
            ans._edges.Add(new Edge(ans._points[3], ans._points[0]));

            ans._edges.Add(new Edge(ans._points[4], ans._points[5]));
            ans._edges.Add(new Edge(ans._points[5], ans._points[6]));
            ans._edges.Add(new Edge(ans._points[7], ans._points[6]));
            ans._edges.Add(new Edge(ans._points[7], ans._points[4]));

            ans._edges.Add(new Edge(ans._points[7], ans._points[3]));
            ans._edges.Add(new Edge(ans._points[4], ans._points[0]));
            ans._edges.Add(new Edge(ans._points[5], ans._points[1]));
            ans._edges.Add(new Edge(ans._points[6], ans._points[2]));
            return ans;
        }
        public static Polyhedron Tetrahedron(float size)
        {
            Polyhedron ans = new Polyhedron();
            ans._points.Add(new Point(0, 0, 0));
            ans._points.Add(new Point(size, 0, 0));
            ans._points.Add(new Point(size/2, size*(float)Math.Sqrt(3) / 2, 0));
            ans._points.Add(new Point(size/2, size * (float)Math.Sqrt(3) / 6, size * (float)Math.Sqrt(1.0/3)));

            ans._edges.Add(new Edge(ans._points[0], ans._points[1]));
            ans._edges.Add(new Edge(ans._points[0], ans._points[2]));
            ans._edges.Add(new Edge(ans._points[0], ans._points[3]));
            ans._edges.Add(new Edge(ans._points[1], ans._points[2]));
            ans._edges.Add(new Edge(ans._points[1], ans._points[3]));
            ans._edges.Add(new Edge(ans._points[3], ans._points[2]));

            return ans;
        }

        public static Polyhedron Octahedron(float size)
        {
            Polyhedron ans = new Polyhedron();
            ans._points.Add(new Point(size / 2, size / 2, 0));
            ans._points.Add(new Point(0, size / 2, size / 2));
            ans._points.Add(new Point(size / 2, 0, size / 2));
            ans._points.Add(new Point(size, size / 2, size / 2));
            ans._points.Add(new Point(size / 2, size, size / 2));
            ans._points.Add(new Point(size / 2, size / 2, size));

            
            ans._edges.Add(new Edge(ans._points[0], ans._points[1]));
            ans._edges.Add(new Edge(ans._points[0], ans._points[2]));
            ans._edges.Add(new Edge(ans._points[0], ans._points[3]));
            ans._edges.Add(new Edge(ans._points[0], ans._points[4]));

            ans._edges.Add(new Edge(ans._points[5], ans._points[1]));
            ans._edges.Add(new Edge(ans._points[5], ans._points[2]));
            ans._edges.Add(new Edge(ans._points[5], ans._points[3]));
            ans._edges.Add(new Edge(ans._points[5], ans._points[4]));

            ans._edges.Add(new Edge(ans._points[1], ans._points[2]));
            ans._edges.Add(new Edge(ans._points[2], ans._points[3]));
            ans._edges.Add(new Edge(ans._points[3], ans._points[4]));
            ans._edges.Add(new Edge(ans._points[4], ans._points[1]));

            return ans;
        }
        public static Polyhedron Icosahedron(float size)
        {
            Polyhedron ans = new Polyhedron();
            float height = size * 0.5f;
            float degree = 0;
            for (int i = 0; i < 10; i++)
            {
                double phi = Math.PI * degree / 180;
                //points.Add(new Point3D(Math.Sin(phi) * size, height, Math.Cos(phi) * size));
                ans._points.Add(new Point((float)Math.Sin(phi) * size, height, (float)Math.Cos(phi) * size));
                degree += 36;
                height *= -1;
            }

            ans._points.Add(new Point(0, (float)Math.Sqrt(5) * height, 0));
            ans._points.Add(new Point(0, -(float)Math.Sqrt(5) * height, 0));
            //30 ребер
            //по бокам
            for (int i = 0; i < 9; i++)
            {
                ans._edges.Add(new Edge(ans._points[i], ans._points[i+1]));
            }
                
            ans._edges.Add(new Edge(ans._points[9], ans._points[0]));

            //по окружностям 
            for (int i = 0; i < 8; i++)
            {
                ans._edges.Add(new Edge(ans._points[i], ans._points[i + 2]));
            }

            ans._edges.Add(new Edge(ans._points[8], ans._points[0]));
            ans._edges.Add(new Edge(ans._points[9], ans._points[1]));
            //верхние грани
            for (int i = 0; i < 9; i += 2)
            {
                ans._edges.Add(new Edge(ans._points[10], ans._points[i]));
            }
            //нижние грани
            for (int i = 1; i < 10; i += 2)
            {
                ans._edges.Add(new Edge(ans._points[11], ans._points[i]));
            }

            return ans;
        }
        private static Point CenterofGravity(Point p1, Point p2, Point p3)
        {
            return
                new Point(
                    (p1.X + p2.X + p3.X) / 3,
                    (p1.Y + p2.Y + p3.Y) / 3,
                    (p1.Z + p2.Z + p3.Z) / 3
                    ) ;
        }
        public static Polyhedron Dodecahedron(float size)
        {
            Polyhedron ans = new Polyhedron();
            List<Point> points_icosa = new List<Point>();
            double height = size * 0.5;
            double degree = 0;
            for (int i = 0; i < 10; i++)
            {
                double phi = Math.PI * degree / 180;
                points_icosa.Add(new Point(Math.Sin(phi) * size, height, Math.Cos(phi) * size));
                degree += 36;
                height *= -1;
            }

            points_icosa.Add(new Point(0, Math.Sqrt(5) * height, 0));
            points_icosa.Add(new Point(0, -Math.Sqrt(5) * height, 0));
            //center_point = new Point3D(0, 0, 0);

            for (int i = 0; i < 8; i++)//боковвые
                ans._points.Add(CenterofGravity(points_icosa[i], points_icosa[i + 1], points_icosa[i + 2]));
            ans._points.Add(CenterofGravity(points_icosa[8], points_icosa[9], points_icosa[0]));
            ans._points.Add(CenterofGravity(points_icosa[9], points_icosa[0], points_icosa[1]));

            for (int i = 0; i < 7; i += 2)//верхние
                ans._points.Add(CenterofGravity(points_icosa[10], points_icosa[i], points_icosa[i + 2]));
            ans._points.Add(CenterofGravity(points_icosa[10], points_icosa[8], points_icosa[0]));

            for (int i = 1; i < 8; i += 2)//нижние
                ans._points.Add(CenterofGravity(points_icosa[11], points_icosa[i], points_icosa[i + 2]));
            ans._points.Add(CenterofGravity(points_icosa[11], points_icosa[9], points_icosa[1]));

            for (int i = 0; i < 9; i++)
                ans._edges.Add(new Edge(ans._points[i], ans._points[i+1]));
            ans._edges.Add(new Edge(ans._points[9], ans._points[0]));

            for (int i = 0; i < 5; i++)
                ans._edges.Add(new Edge(ans._points[i*2], ans._points[i + 10]));
            for (int i = 0; i < 5; i++)
                ans._edges.Add(new Edge(ans._points[i * 2+1], ans._points[i + 15]));

            for (int i = 10; i < 14; i++)//верхние
                ans._edges.Add(new Edge(ans._points[i], ans._points[i + 1]));
            ans._edges.Add(new Edge(ans._points[10], ans._points[14]));

            for (int i = 15; i < 19; i++)//нижние
                ans._edges.Add(new Edge(ans._points[i], ans._points[i + 1]));
            ans._edges.Add(new Edge(ans._points[15], ans._points[19]));
            return ans;
        }
        public static Polyhedron Axes(float size)
        {
            Polyhedron ans = new Polyhedron();
            ans._points.Add(new Point(0, 0, 0));
            ans._points.Add(new Point(0, size, 0));
            ans._points.Add(new Point(size, 0, 0));
            ans._points.Add(new Point(0, 0, size));

            ans._edges.Add(new Edge(ans._points[0], ans._points[1]));
            ans._edges.Add(new Edge(ans._points[0], ans._points[2]));
            ans._edges.Add(new Edge(ans._points[0], ans._points[3]));
            return ans;
        }
    }
}
