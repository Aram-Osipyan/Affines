using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3DAfines;
namespace _2VarPlotting
{
    public partial class Form1 : Form
    {
        Polyhedron _axes;
        Plot _plot;
        Graphics _graphics;
        public Form1()
        {
            InitializeComponent();
            _axes = Polyhedron.Axes(500);
            _graphics = pictureBox1.CreateGraphics();
            _plot = new Plot(Func6);
            _plot.LineRotate(new _3DAfines.Point(1, 0, 0), 90);
            _plot.LineRotate(new _3DAfines.Point(0, 0, 1), 180);
        }
        private float Func6(float x, float y)
        {
            return 200*(MathF.Sin(x) * MathF.Cos(y));
        }
        private float Func1(float x,float y)
        {
            return -(MathF.Sqrt(x * x + y * y))+50;
        }
        private float Func3(float x, float y)
        {
            return 100*MathF.Cos(x+y);
        }
        private float Func2(float x, float y)
        {
            return 0;
        }
        private float Func4(float x,float y)
        {
            float p = 50;
            if (x>-p && x<p && y > -p && y < p)
            {
                return -100;
            }
            return 0;
        }
        private void DrawAxes()
        {
            _axes.Edges[0].DrawIso(_graphics, Pens.Red);
            _axes.Edges[1].DrawIso(_graphics, Pens.Green);
            _axes.Edges[2].DrawIso(_graphics, Pens.Blue);
        }
        private void UpdateScene()
        {
            _graphics.Clear(Color.White);
            DrawAxes();
            _plot.DrawIso(_graphics, Pens.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateScene();
        }

        
        private void XRot_Scroll(object sender, ScrollEventArgs e)
        {
            _3DAfines.Point dPoint = _plot.Center;
            _plot.Translate(-dPoint.X, -dPoint.Y, -dPoint.Z);
            _plot.Rotate(e.NewValue - e.OldValue, 0, 0);
            _plot.Translate(dPoint.X, dPoint.Y, dPoint.Z);
            UpdateScene();
        }

        private void YRot_Scroll(object sender, ScrollEventArgs e)
        {
            _3DAfines.Point dPoint = _plot.Center;
            _plot.Translate(-dPoint.X, -dPoint.Y, -dPoint.Z);
            _plot.Rotate(0, e.NewValue - e.OldValue, 0);
            _plot.Translate(dPoint.X, dPoint.Y, dPoint.Z);

            UpdateScene();
        }

        private void ZRot_Scroll(object sender, ScrollEventArgs e)
        {
            _plot.Rotate(0, e.NewValue - e.OldValue, 0);
            UpdateScene();
        }
    }
}
