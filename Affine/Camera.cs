using System;
using System.Drawing;

namespace Affine
{
    public class Camera
    {
        private Point _viewDirection;
        private Point _viewRotation;
        public Point Position { get; set; }

        public Point ViewDirection 
        {
            get
            {
                return _viewDirection;
            }
            set
            {
                Point p = value.Copy();
                p.Normalize();
                _viewDirection = p;
            }
        }
        public Func<Point, PointF> Projection { get; set; }

        public Camera(Point position,Func<Point,PointF> projection)
        {
            Position = position;
            ViewDirection = new Point(0,0,1);
            Projection = projection;
            _viewRotation = new Point(0,0,0);
        }
        public void ViewRotate(float dx,float dy,float dz)
        {
            _viewRotation.X += dx;
            _viewRotation.Y += dy;
            _viewRotation.Z += dz;
            ViewDirection = new Point(0, 0, 1);
            ViewDirection.Rotate(_viewRotation.X, _viewRotation.Y,_viewRotation.Z);
        }
        public PointF PointImage(Point point)
        { 
            Point p2 = point.Copy();
            p2.X -= Position.X;
            p2.Y -= Position.Y;
            p2.Z -= Position.Z;
            p2.Rotate(-_viewRotation.X, - _viewRotation.Y, -_viewRotation.Z);
            return Projection(p2);
        }
        
    }
}
