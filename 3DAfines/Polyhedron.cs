using System;
using System.Collections.Generic;
using System.Drawing;

namespace _3DAfines
{
    public class Polyhedron
    {
        public List<Point> _points;
        public List<Edge> _edges;
        public List<List<int>> faces = new List<List<int>>();

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

            ans.faces.Add(new List<int> { 0, 1, 3, 2 });
            ans.faces.Add(new List<int> { 1, 5, 7, 3 });
            ans.faces.Add(new List<int> { 5, 4, 6, 7 });
            ans.faces.Add(new List<int> { 4, 5, 1, 0 });
            ans.faces.Add(new List<int> { 2, 6, 4, 0 });
            ans.faces.Add(new List<int> { 2, 3, 7, 6 });
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

            ans.faces.Add(new List<int> { 0, 1, 2 });
            ans.faces.Add(new List<int> { 0, 2, 3 });
            ans.faces.Add(new List<int> { 0, 3, 1 });
            ans.faces.Add(new List<int> { 1, 3, 2 });

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

            ans.faces.Add(new List<int> { 0, 1, 2 });
            ans.faces.Add(new List<int> { 0, 2, 3 });
            ans.faces.Add(new List<int> { 2, 5, 3 });
            ans.faces.Add(new List<int> { 1, 5, 2 });
            ans.faces.Add(new List<int> { 1, 0, 4 });
            ans.faces.Add(new List<int> { 0, 3, 4 });
            ans.faces.Add(new List<int> { 4, 3, 5 });
            ans.faces.Add(new List<int> { 1, 4, 5 });

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

        public Point GetCentralPoint()
        {
            float xSumm = 0.0f;
            float ySumm = 0.0f;
            float ZSumm = 0.0f;
            foreach (Point point in _points)
            {
                xSumm += point.X;
                ySumm += point.Y;
                ZSumm += point.Z;
            }

            return new Point(xSumm / _points.Count, ySumm / _points.Count, ZSumm / _points.Count);
        }

       /*public Point FaceToNormal(List<int> faces)
        {
            Point firstPoint = _points[faces[0]];
            Point secondPoint = _points[faces[1]];
            Point thirdPoint = _points[faces[2]];

            var vec1 = secondPoint - firstPoint;
            var vec2 = firstPoint - thirdPoint;

            return new Point(vec1.Y * vec2.Z - vec1.Z * vec2.Y,
                        vec1.Z * vec2.X - vec1.X * vec2.Z,
                        vec1.X * vec2.Y - vec1.Y * vec2.X);
        }

        public List<List<int>> GetFrontFaces(Point sightPoint)
        {
            var frontFaces = new List<List<int>>();

            foreach (var face in faces)
            {
                if (angleIsObtuse(FaceToNormal(face), sightPoint))
                {
                    frontFaces.Add(face);
                } 
            }
                
            return frontFaces;
        }*/
    }
}
