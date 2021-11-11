using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _3DAfines
{
    class ZBuffer
    {
        public static Bitmap ApplyBuffer(int width, int height, List<Polyhedron> polyhedrons)
        {
            double[,] zBuffer = new double[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    zBuffer[i, j] = Double.MinValue;
                }
            }

            Bitmap resultIm = new Bitmap(width, height);

            Polyhedron _axes = Polyhedron.Axes(500);
            Graphics _graphics1 = Graphics.FromImage(resultIm);
            _axes.Edges[0].DrawParall(_graphics1, Pens.Red);
            _axes.Edges[1].DrawParall(_graphics1, Pens.Green);
            _axes.Edges[2].DrawParall(_graphics1, Pens.Blue);

            List<List<List<Point>>> rasterImage = new List<List<List<Point>>>();
            for (int i = 0; i < polyhedrons.Count; i++)
            {
                rasterImage.Add(RasterizePolyhydron(polyhedrons[i]));
            }

            for (int i = 0; i < rasterImage.Count; i++)
            {
                Color currColor = Color.Black;
                for (int j = 0; j < rasterImage[i].Count; j++)
                {
                    List<Point> curr = rasterImage[i][j];
                    foreach (Point point in curr)
                    {
                        int x = (int)(point.X);
                        int y = (int)(point.Y);

                        if (x < width && y < height && x > 0 && y > 0)
                        {
                            if (point.Z > zBuffer[x, y])
                            {
                                zBuffer[x, y] = point.Z;
                                resultIm.SetPixel(x, y, currColor);
                            }
                        }
                    }
                    currColor = Color.FromArgb(currColor.R + 20, currColor.G + 20, currColor.B + 20);
                }
            }
            return resultIm;
        }

        private static List<List<Point>> RasterizePolyhydron(Polyhedron polyhedron)
        {
            List<List<Point>> rasterized = new List<List<Point>>();
            foreach (List<int> face in polyhedron.faces)
            {
                List<Point> facetPoints = new List<Point>();
                List<Point> polyhydronPoints = polyhedron._points;
                List<Point> runFace = new List<Point>();
                for (int i = 0; i < face.Count; i++)
                {
                    facetPoints.Add(polyhydronPoints[face[i]]);
                }
                runFace.AddRange(RasterizeFacet(facetPoints));
                rasterized.Add(runFace);
            }
            return rasterized;
        }

        private static List<Point> RasterizeFacet(List<Point> points)
        {
            List<List<Point>> triangles = Triangulate(points);
            List<Point> result = new List<Point>();
            foreach (List<Point> triangle in triangles)
            {
                var res = new List<Point>();
                foreach (Point point in triangle)
                {
                    res.Add(point);
                }
                result.AddRange(RasterTriangle(res));
            }
                
            return result;
        }

        private static List<Point> RasterTriangle(List<Point> points)
        {
            List<Point> res = new List<Point>();

            points.Sort((fPoint, sPoint) => fPoint.Y.CompareTo(sPoint.Y));

            List<int> interX1 = Interpolation((int)points[0].Y, (int)points[0].X, (int)points[1].Y, (int)points[1].X);
            List<int> interX2 = Interpolation((int)points[1].Y, (int)points[1].X, (int)points[2].Y, (int)points[2].X);
            List<int> interX3 = Interpolation((int)points[0].Y, (int)points[0].X, (int)points[2].Y, (int)points[2].X);

            List<int> interZ1 = Interpolation((int)points[0].Y, (int)points[0].Z, (int)points[1].Y, (int)points[1].Z);
            List<int> interZ2 = Interpolation((int)points[1].Y, (int)points[1].Z, (int)points[2].Y, (int)points[2].Z);
            List<int> interZ3 = Interpolation((int)points[0].Y, (int)points[0].Z, (int)points[2].Y, (int)points[2].Z);

            interX1.RemoveAt(interX1.Count - 1);
            List<int> unitedX = interX1.Concat(interX2).ToList();

            interZ1.RemoveAt(interZ1.Count - 1);
            List<int> unitedZ = interZ1.Concat(interZ2).ToList();

            int middle = unitedX.Count / 2;
            List<int> leftX, rightX, leftZ, rightZ;
            if (interX3[middle] < unitedX[middle])
            {
                leftX = interX3;
                rightX = unitedX;

                leftZ = interZ3;
                rightZ = unitedZ;
            }
            else
            {
                leftX = unitedX;
                rightX = interX3;

                leftZ = unitedZ;
                rightZ = interZ3;
            }

            int y0 = (int)points[0].Y;
            int y2 = (int)points[2].Y;
            while (y2 - y0 > leftX.Count || y2 - y0 > rightX.Count || y2 - y0 > rightZ.Count || y2 - y0 > leftZ.Count)
            {
                --y2;
            }
            for (int ind = 0; ind < y2 - y0; ind++)
            {
                int XL = leftX[ind];
                int XR = rightX[ind];

                List<int> intCurrZ = Interpolation(XL, leftZ[ind], XR, rightZ[ind]);

                for (int x = XL; x < XR; x++)
                    res.Add(new Point(x, y0 + ind, intCurrZ[x - XL]));
            }
            return res;
        }

        private static List<List<Point>> Triangulate(List<Point> points)
        {
            List<List<Point>> res = new List<List<Point>>();
            if (points.Count == 3)
            {
                return new List<List<Point>> { points };
            }   

            for (int i = 2; i < points.Count; i++)
            {
                res.Add(new List<Point> { points[0], points[i - 1], points[i] });
            }   

            return res;
        }

        private static List<int> Interpolation(int yFirst, int xFirst, int ySecond, int xSecond)
        {
            if (yFirst == ySecond)
            {
                return new List<int> { xFirst };
            }   
            
            double step = (xSecond - xFirst) * 1.0 / (ySecond - yFirst);
            double value = xFirst;
            List<int> result = new List<int>();
            for (int i = yFirst; i <= ySecond; i++)
            {
                result.Add((int)value);
                value += step;
            }
            return result;
        }
    }
}
