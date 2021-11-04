using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace _3DAfines
{
    class Polyhedron
    {
        private List<Point> _points;
        private List<Edge> _edges;
        private Point _center;
        public Dictionary<int, List<int>> FaceToPoints = new Dictionary<int, List<int>>();
        public Point Center
        {
            get
            {
                return _center;
            }
        }
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
            _center.Translate(dx, dy, dz);
        }
        public void Rotate(float ax, float ay, float az)
        {
            foreach (var item in _points)
            {
                item.Rotate(ax, ay, az);
            }
            _center.Rotate(ax, ay, az);
        }
        public void Scale(float ax, float ay, float az)
        {
            foreach (var item in _points)
            {
                item.Scale(ax, ay, az);
            }
            _center.Scale(ax, ay, az);
        }
        public void CenterScale(float ax, float ay, float az)
        {
            Point center = Center.Copy();
            Translate(-Center.X, -Center.Y, -Center.Z);
            Scale(ax, ay, az);
            Translate(Center.X +center.X, Center.Y + center.Y, Center.Z + center.Z);

        }
        public void LineRotate(Point vec, float angle)
        {
            foreach (var item in _points)
            {
                item.LineRotate(vec,angle);
            }
            _center.LineRotate(vec,angle);
        }

        public void ReflectionYZ()
        {
            foreach (var item in _points)
            {
                item.ReflectionYZ();
            }
        }

        public void ReflectionZX()
        {
            foreach (var item in _points)
            {
                item.ReflectionZX();
            }
        }

        public void ReflectionXY()
        {
            foreach (var item in _points)
            {
                item.ReflectionXY();
            }
        }

        public static Polyhedron Hexahedron(float size)
        {
            Polyhedron ans = new Polyhedron();
            ans._center = new Point(size / 2, size / 2, size / 2);
            ans._points.Add(new Point(0, 0, 0));
            ans._points.Add(new Point(0, size, 0));
            ans._points.Add(new Point(size, size, 0));
            ans._points.Add(new Point(size, 0, 0));

            ans._points.Add(new Point(0, 0, size));
            ans._points.Add(new Point(0, size, size));
            ans._points.Add(new Point(size, size, size));
            ans._points.Add(new Point(size, 0, size));

            //ans.FaceToPoints[1] = new List<int>() { 2, 3, 7, 6 };
            //ans.FaceToPoints[2] = new List<int>() { 6, 7, 4, 5 };
            //ans.FaceToPoints[3] = new List<int>() { 5, 4, 0, 1 };
            //ans.FaceToPoints[4] = new List<int>() { 1, 0, 3, 2 };
            //ans.FaceToPoints[5] = new List<int>() { 2, 6, 5, 1 };
            //ans.FaceToPoints[6] = new List<int>() { 3, 7, 4, 0 };

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
        public static Point CenterofGravity(List<Point> l)
        {
            Point p = new Point();
            foreach (Point p1 in l)
            {
                p.X += p1.X;
                p.Y += p1.Y;
                p.Z += p1.Z;
            }
            p.X /= l.Count;
            p.Y /= l.Count;
            p.Z /= l.Count;
            return p;

        }
        public static Polyhedron Tetrahedron(float size)
        {
            Polyhedron ans = new Polyhedron();
            
            ans._points.Add(new Point(0, 0, 0));
            ans._points.Add(new Point(size, size, 0));
            ans._points.Add(new Point(0, size, size));
            ans._points.Add(new Point(size, 0, size )); 
            ans._center = CenterofGravity(ans._points);
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
            ans._center = new Point(size / 2, size / 2, size / 2);
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
            ans._center = new Point(0, 0, 0);
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
            ans._center = new Point(0, 0, 0);
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

        public static Polyhedron GetFromFile(string s)
        {
            Polyhedron ans = new Polyhedron();
            ans._points = new List<Point>();
            var arr = s.Split('\n');
            string[] center = arr[0].Split(' ');
            ans._center = new Point(float.Parse(center[0]), float.Parse(center[1]), float.Parse(center[2]));
            Dictionary<(float, float, float), int> pointToId = new Dictionary<(float, float, float), int>();
            for(int i = 1; i < arr.Length; ++i)
            {
                string s1 = arr[i];
                if (string.IsNullOrEmpty(arr[i]))
                    continue;
                var arr1 = s1.Split(' ').Where(x => x.Length != 0).ToList();
                List<Point> curPoints = new List<Point>();
                ans.FaceToPoints[i] = new List<int>();
                for(int j = 0; j < arr1.Count; j +=3)
                {
                    float x = (float)Math.Truncate(float.Parse(arr1[j], CultureInfo.InvariantCulture));
                    float y = (float)Math.Truncate(float.Parse(arr1[j + 1], CultureInfo.InvariantCulture));
                    float z = (float)Math.Truncate(float.Parse(arr1[j + 2], CultureInfo.InvariantCulture));
                    var coordinate = (x, y, z);
                    
                    if(!pointToId.ContainsKey(coordinate))
                    {
                        Point p = new Point(x, y, z);
                        ans._points.Add(p);
                        pointToId[coordinate] = ans._points.Count - 1;
                        curPoints.Add(p);
                        ans.FaceToPoints[i].Add(ans._points.Count - 1);
                    }
                    else
                    {
                        int pointId = pointToId[coordinate];
                        curPoints.Add(ans._points[pointId]);
                        ans.FaceToPoints[i].Add(pointId);
                    }

                }
                for(int j = 0; j < curPoints.Count - 1; j++)
                {
                    ans._edges.Add(new Edge(curPoints[j], curPoints[j + 1]));
                }
                ans._edges.Add(new Edge(curPoints[0], curPoints[curPoints.Count - 1]));
            }
            return ans;
        }

        public string SaveToFile()
        {
            string res = _center.X + " " + _center.Y + " " + _center.Z + "\n";
            foreach(var face_point in FaceToPoints)
            {
                List<int> pointsIds = face_point.Value;
                for(int  i = 0; i < pointsIds.Count; ++i)
                {
                    Point curPoint = _points[pointsIds[i]];
                    res += Math.Truncate(curPoint.X).ToString() + " ";
                    res += Math.Truncate(curPoint.Y).ToString() + " ";
                    res += Math.Truncate(curPoint.Z).ToString() + " ";
                }
                res += '\n';
            }
            return res;
        }
    }
}
