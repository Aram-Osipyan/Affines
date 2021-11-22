using System;
using System.Collections.Generic;
using System.Text;
using _3DAfines;
namespace _2VarPlotting
{
    class Plot:Polyhedron
    {
        public Plot(Func<float,float,float> func,
            float x0 = -250, 
            float x1 = 250, 
            float y0 = -250 , 
            float y1 = 250,int xpartitions = 20, int ypartitions = 20):base()
        {
            float xStep = (x1 - x0) / xpartitions;
            float yStep = (y1 - y0) / ypartitions;
            Center = new Point(0,0,0);
            for (float ix = x0; ix < x1; ix+= xStep)
            {
                for (float iy = y0; iy < y1; iy+=yStep)
                {
                    Point point = new Point(ix, iy, func(ix, iy));
                    this.Points.Add(point);
                }
            }
            for (int ix = 0; ix < xpartitions; ix++)
            {
                for (int iy = 1; iy < ypartitions; iy++)
                {
                    this.Edges.Add(new Edge(Points[ix*xpartitions+iy], Points[ix * xpartitions + iy-1]));
                }
            }
            for (int iy = 0; iy < ypartitions; iy++)
            {
                for (int ix = 1; ix < xpartitions; ix++)
                {
                    this.Edges.Add(new Edge(Points[(ix-1) * xpartitions + iy], Points[ix * xpartitions + iy]));
                }
            }
        }
    }
}
