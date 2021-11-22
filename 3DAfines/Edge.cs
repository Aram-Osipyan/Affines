using System.Drawing;

namespace _3DAfines
{
    public class Edge
    {
        public _3DAfines.Point First { get; set; }
        public _3DAfines.Point Second { get; set; }
        public Edge(_3DAfines.Point _first, _3DAfines.Point _second)
        {
            First = _first;
            Second = _second;
        }
        public void DrawParall(Graphics graphics,Pen pen, int offset = 100)
        {
            graphics.DrawLine(pen, 
                First.X + offset, 
                First.Y + offset, 
                Second.X + offset, 
                Second.Y + offset);
        }

        public void DrawIso(Graphics graphics, Pen pen,int offset = 100)
        {
            Point point1 = Point.iso3Dto2D(First);
            Point point2 = Point.iso3Dto2D(Second);
            graphics.DrawLine(pen, 
                point1.X + offset, 
                point1.Y + offset, 
                point2.X + offset, 
                point2.Y + offset);
            //graphics.DrawEllipse(Pens.Red, point1.X-5 + offset, point1.Y-5 + offset, 10, 10);
            //graphics.DrawEllipse(Pens.Red, point2.X-5 + offset, point2.Y-5 + offset, 10, 10);
        }
        
    }

}
