﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace Affine
{
    public class Polyhedron
    {
        public List<Polygon> Polygons { get; set; } = null;
        public Point Center { get; set; } = new Point(0, 0, 0);
        public Polyhedron(List<Polygon> fs = null)
        {
            if (fs != null)
            {
                Polygons = fs.Select(face => new Polygon(face)).ToList();
                UpdateCenter();
            }
        }

        
        private void UpdateCenter()
        {
            Center.X = 0;
            Center.Y = 0;
            Center.Z = 0;
            foreach (Polygon f in Polygons)
            {
                Center.X += f.Center.X;
                Center.Y += f.Center.Y;
                Center.Z += f.Center.Z;
            }
            Center.X /= Polygons.Count;
            Center.Y /= Polygons.Count;
            Center.Z /= Polygons.Count;
        }
                
        public void Show(Graphics g, Projection pr = 0, Pen pen = null)
        {

            foreach (Polygon f in Polygons)
            {
                //f.FindNormal(Center, new Edge(new Point(0, 0, 500), new Point(0, 0, 500)));
                if (f.IsVisible(Center, new Edge(new Point(0, 0, 500), new Point(0, 0, 500))))
                    f.Show(g, pr, pen);
            }            

        }

        public void Show(Graphics g,Camera camera, Pen pen = null)
        {

            foreach (Polygon f in Polygons)
            {
                f.PolyhedronCenter = Center;
                if (f.IsVisible(camera))
                    f.DrawByCamera(g,camera,pen);
            }

        }
        public void Translate(float x, float y, float z)
        {
            foreach (Polygon f in Polygons)
                f.translate(x, y, z);
            UpdateCenter();
        }

        public void Rotate(double angle, Axis a, Edge line = null)
        {
            foreach (Polygon f in Polygons)
                f.rotate(angle, a, line);
            UpdateCenter();
        }

        public void Scale(float kx, float ky, float kz)
        {
            foreach (Polygon f in Polygons)
                f.scale(kx, ky, kz);
            UpdateCenter();
        }


        public void Hexahedron(float cube_half_size = 50)
        {
            Polygon f = new Polygon(
                          new List<Point>
                          {
                    new Point(-cube_half_size, cube_half_size, cube_half_size),
                    new Point(cube_half_size, cube_half_size, cube_half_size),
                    new Point(cube_half_size, -cube_half_size, cube_half_size),
                    new Point(-cube_half_size, -cube_half_size, cube_half_size)
                          }
                      );

            Polygons = new List<Polygon> { f }; // front face

            // back face
            Polygon f1 = new Polygon(
                    new List<Point>
                    {
                        new Point(-cube_half_size, cube_half_size, -cube_half_size),
                        new Point(-cube_half_size, -cube_half_size, -cube_half_size),
                        new Point(cube_half_size, -cube_half_size, -cube_half_size),
                        new Point(cube_half_size, cube_half_size, -cube_half_size)
                    });

            Polygons.Add(f1);

            // down face
            List<Point> l2 = new List<Point>
            {
                new Point(f.Points[2]),
                new Point(f1.Points[2]),
                new Point(f1.Points[1]),
                new Point(f.Points[3]),
            };
            Polygon f2 = new Polygon(l2);
            Polygons.Add(f2);

            // up face
            List<Point> l3 = new List<Point>
            {
                new Point(f1.Points[0]),
                new Point(f1.Points[3]),
                new Point(f.Points[1]),
                new Point(f.Points[0]),
            };

            Polygon f3 = new Polygon(l3);
            Polygons.Add(f3);

            // left face
            List<Point> l4 = new List<Point>
            {
                new Point(f1.Points[0]),
                new Point(f.Points[0]),
                new Point(f.Points[3]),
                new Point(f1.Points[1])
            };

            Polygon f4 = new Polygon(l4);
            Polygons.Add(f4);

            // right face
            List<Point> l5 = new List<Point>
            {
                new Point(f1.Points[3]),
                new Point(f1.Points[2]),
                new Point(f.Points[2]),
                new Point(f.Points[1])
            };

            Polygon f5 = new Polygon(l5);
            Polygons.Add(f5);

            UpdateCenter();
        }

        public void Tetrahedron(Polyhedron cube = null)
        {
            if (cube == null)
            {
                cube = new Polyhedron();
                cube.Hexahedron();
            }
            Polygon f0 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[0].Points[0]),
                    new Point(cube.Polygons[1].Points[1]),
                    new Point(cube.Polygons[1].Points[3])
                }
            );

            Polygon f1 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[1].Points[3]),
                    new Point(cube.Polygons[1].Points[1]),
                    new Point(cube.Polygons[0].Points[2])
                }
            );

            Polygon f2 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[0].Points[2]),
                    new Point(cube.Polygons[1].Points[1]),
                    new Point(cube.Polygons[0].Points[0])
                }
            );

            Polygon f3 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[0].Points[2]),
                    new Point(cube.Polygons[0].Points[0]),
                    new Point(cube.Polygons[1].Points[3])
                }
            );

            Polygons = new List<Polygon> { f0, f1, f2, f3 };
            UpdateCenter();
        }

        public void Octahedron(Polyhedron cube = null)
        {
            if (cube == null)
            {
                cube = new Polyhedron();
                cube.Hexahedron();
            }

            Polygon f0 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[2].Center),
                    new Point(cube.Polygons[1].Center),
                    new Point(cube.Polygons[4].Center)
                }
            );


            Polygon f1 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[2].Center),
                    new Point(cube.Polygons[1].Center),
                    new Point(cube.Polygons[5].Center)
                }
            );


            Polygon f2 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[2].Center),
                    new Point(cube.Polygons[5].Center),
                    new Point(cube.Polygons[0].Center)
                }
            );


            Polygon f3 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[2].Center),
                    new Point(cube.Polygons[0].Center),
                    new Point(cube.Polygons[4].Center)
                }
            );


            Polygon f4 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[3].Center),
                    new Point(cube.Polygons[1].Center),
                    new Point(cube.Polygons[4].Center)
                }
            );

            Polygon f5 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[3].Center),
                    new Point(cube.Polygons[1].Center),
                    new Point(cube.Polygons[5].Center)
                }
            );

            Polygon f6 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[3].Center),
                    new Point(cube.Polygons[5].Center),
                    new Point(cube.Polygons[0].Center)
                }
            );

            Polygon f7 = new Polygon(
                new List<Point>
                {
                    new Point(cube.Polygons[3].Center),
                    new Point(cube.Polygons[0].Center),
                    new Point(cube.Polygons[4].Center)
                }
            );

            Polygons = new List<Polygon> { f0, f1, f2, f3, f4, f5, f6, f7 };
            UpdateCenter();
        }

        public void Icosahedron()
        {
            Polygons = new List<Polygon>();

            float size = 100;

            float r1 = size * (float)Math.Sqrt(3) / 4;
            float r = size * (3 + (float)Math.Sqrt(5)) / (4 * (float)Math.Sqrt(3));

            Point up_center = new Point(0, -r1, 0);
            Point down_center = new Point(0, r1, 0);

            double a = Math.PI / 2;
            List<Point> up_points = new List<Point>();
            for (int i = 0; i < 5; ++i)
            {
                up_points.Add(new Point(up_center.X + r * (float)Math.Cos(a), up_center.Y, up_center.Z - r * (float)Math.Sin(a)));
                a += 2 * Math.PI / 5;
            }

            a = Math.PI / 2 - Math.PI / 5;
            List<Point> down_points = new List<Point>();
            for (int i = 0; i < 5; ++i)
            {
                down_points.Add(new Point(down_center.X + r * (float)Math.Cos(a), down_center.Y, down_center.Z - r * (float)Math.Sin(a)));
                a += 2 * Math.PI / 5;
            }

            var R = Math.Sqrt(2 * (5 + Math.Sqrt(5))) * size / 4;

            Point p_up = new Point(up_center.X, (float)(-R), up_center.Z);
            Point p_down = new Point(down_center.X, (float)R, down_center.Z);

            for (int i = 0; i < 5; ++i)
            {
                Polygons.Add(
                    new Polygon(new List<Point>
                    {
                        new Point(p_up),
                        new Point(up_points[i]),
                        new Point(up_points[(i+1) % 5]),
                    })
                    );
            }

            for (int i = 0; i < 5; ++i)
            {
                Polygons.Add(
                    new Polygon(new List<Point>
                    {
                        new Point(p_down),
                        new Point(down_points[i]),
                        new Point(down_points[(i+1) % 5]),
                    })
                    );
            }

            for (int i = 0; i < 5; ++i)
            {
                Polygons.Add(
                    new Polygon(new List<Point>
                    {
                        new Point(up_points[i]),
                        new Point(up_points[(i+1) % 5]),
                        new Point(down_points[(i+1) % 5])
                    })
                    );

                Polygons.Add(
                    new Polygon(new List<Point>
                    {
                        new Point(up_points[i]),
                        new Point(down_points[i]),
                        new Point(down_points[(i+1) % 5])
                    })
                    );
            }

            UpdateCenter();
        }

        public void Dodecahedron()
        {
            Polygons = new List<Polygon>();
            Polyhedron ik = new Polyhedron();
            ik.Icosahedron();

            List<Point> pts = new List<Point>();
            foreach (Polygon f in ik.Polygons)
            {
                pts.Add(f.Center);
            }

            Polygons.Add(new Polygon(new List<Point>
            {
                new Point(pts[0]),
                new Point(pts[1]),
                new Point(pts[2]),
                new Point(pts[3]),
                new Point(pts[4])
            }));

            Polygons.Add(new Polygon(new List<Point>
            {
                new Point(pts[5]),
                new Point(pts[6]),
                new Point(pts[7]),
                new Point(pts[8]),
                new Point(pts[9])
            }));

            for (int i = 0; i < 5; ++i)
            {
                Polygons.Add(new Polygon(new List<Point>
                {
                    new Point(pts[i]),
                    new Point(pts[(i + 1) % 5]),
                    new Point(pts[(i == 4) ? 10 : 2*i + 12]),
                    new Point(pts[(i == 4) ? 11 : 2*i + 13]),
                    new Point(pts[2*i + 10])
                }));
            }

            Polygons.Add(new Polygon(new List<Point>
            {
                new Point(pts[5]),
                new Point(pts[6]),
                new Point(pts[13]),
                new Point(pts[10]),
                new Point(pts[11])
            }));
            Polygons.Add(new Polygon(new List<Point>
            {
                new Point(pts[6]),
                new Point(pts[7]),
                new Point(pts[15]),
                new Point(pts[12]),
                new Point(pts[13])
            }));
            Polygons.Add(new Polygon(new List<Point>
            {
                new Point(pts[7]),
                new Point(pts[8]),
                new Point(pts[17]),
                new Point(pts[14]),
                new Point(pts[15])
            }));
            Polygons.Add(new Polygon(new List<Point>
            {
                new Point(pts[8]),
                new Point(pts[9]),
                new Point(pts[19]),
                new Point(pts[16]),
                new Point(pts[17])
            }));
            Polygons.Add(new Polygon(new List<Point>
            {
                new Point(pts[9]),
                new Point(pts[5]),
                new Point(pts[11]),
                new Point(pts[18]),
                new Point(pts[19])
            }));

            UpdateCenter();
        }


      
    }
}
