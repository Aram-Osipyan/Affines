using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotatingForm
{
    public partial class Form1 : Form
    {
        Graphics _graphics1;
        Graphics _graphics2;
        Polyhedron _polyhedron;
        Polyhedron _axes;

        private double point1_x
        {
            get
            {
                return (point1X.Text == "" ? 0 : int.Parse(point1X.Text));
            }
        }
        private double point1_y
        {
            get
            {
                return (point1Y.Text == "" ? 0 : int.Parse(point1Y.Text));
            }
        }
        private double point1_z
        {
            get
            {
                return (point1Z.Text == "" ? 0 : int.Parse(point1Z.Text));
            }
        }
        private double point2_x
        {
            get
            {
                return (point2X.Text == "" ? 0 : int.Parse(point2X.Text));
            }
        }
        private double point2_y
        {
            get
            {
                return (point2Y.Text == "" ? 0 : int.Parse(point2Y.Text));
            }
        }
        private double point2_z
        {
            get
            {
                return (point2Z.Text == "" ? 0 : int.Parse(point2Z.Text));
            }
        }
        private Point LineVector
        {
            get
            {
                return new Point(
                    point2_x - point1_x,
                    point2_y - point1_y,
                    point2_z - point1_z);
            }
        }
        public Form1()
        {
            InitializeComponent();
            _graphics1 = pictureBox1.CreateGraphics();
            _graphics2 = pictureBox2.CreateGraphics();
            _polyhedron = Polyhedron.Hexahedron(60);
            _axes = Polyhedron.Axes(500);
        }
        private void UpdateScene()
        {
            _graphics1.Clear(Color.White);
            _graphics2.Clear(Color.White);
            _polyhedron.DrawParall(_graphics1, Pens.Black);
            _polyhedron.DrawIso(_graphics2, Pens.Black);
            DrawAxes();
        }
        private void DrawAxes()
        {
            _axes.Edges[0].DrawIso(_graphics2, Pens.Red);
            _axes.Edges[1].DrawIso(_graphics2, Pens.Green);
            _axes.Edges[2].DrawIso(_graphics2, Pens.Blue);

            _axes.Edges[0].DrawParall(_graphics1, Pens.Red);
            _axes.Edges[1].DrawParall(_graphics1, Pens.Green);
            _axes.Edges[2].DrawParall(_graphics1, Pens.Blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int divCount = Convert.ToInt32(textBox1.Text);
            string[] points = textBox2.Text.Split();
            List<Point> formPoints = new List<Point>();
            List<Edge> formEdges = new List<Edge>();
            string[] intPoint = points[0].Split(';');
            int xCoord = Convert.ToInt32(intPoint[0]);
            int yCoord = Convert.ToInt32(intPoint[1]);
            formPoints.Add(new Point(xCoord, yCoord, 0));
            for (int i = 1; i < points.Count(); ++i)
            {
                intPoint = points[i].Split(';');
                xCoord = Convert.ToInt32(intPoint[0]);
                yCoord = Convert.ToInt32(intPoint[1]);
                Point curPoint = new Point(xCoord, yCoord, 0);
                formPoints.Add(curPoint);
                formEdges.Add(new Edge(curPoint, formPoints[i - 1]));
            }
            formEdges.Add(new Edge(formPoints[0], formPoints[formPoints.Count - 1]));
            _polyhedron = new Polyhedron(formPoints, formEdges);
            Polyhedron res = _polyhedron.BuildRotateModel(LineVector.Normalize(), divCount);
            _polyhedron = res;
            UpdateScene();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _polyhedron = new Polyhedron();
            UpdateScene();
        }

        private void DXRotate_Scroll(object sender, ScrollEventArgs e)
        {
            if (_scale_mode)
            {
                _polyhedron.Rotate(e.NewValue - e.OldValue, 0, 0);
            }
            else
            {
                Point dPoint = _polyhedron.Center;
                _polyhedron.Translate(-dPoint.X, -dPoint.Y, -dPoint.Z);
                _polyhedron.Rotate(e.NewValue - e.OldValue, 0, 0);
                _polyhedron.Translate(dPoint.X, dPoint.Y, dPoint.Z);
            }
            UpdateScene();
        }

        private void DYRotate_Scroll(object sender, ScrollEventArgs e)
        {
            if (_scale_mode)
            {
                _polyhedron.Rotate(0, e.NewValue - e.OldValue, 0);
            }
            else
            {
                Point dPoint = _polyhedron.Center;
                _polyhedron.Translate(-dPoint.X, -dPoint.Y, -dPoint.Z);
                _polyhedron.Rotate(0, e.NewValue - e.OldValue, 0);
                _polyhedron.Translate(dPoint.X, dPoint.Y, dPoint.Z);
            }

            UpdateScene();
        }
        private void DZRotate_Scroll(object sender, ScrollEventArgs e)
        {
            if (_scale_mode)
            {
                _polyhedron.Rotate(0, 0, e.NewValue - e.OldValue);
            }
            else
            {
                Point dPoint = _polyhedron.Center;
                _polyhedron.Translate(-dPoint.X, -dPoint.Y, -dPoint.Z);
                _polyhedron.Rotate(0, 0, e.NewValue - e.OldValue);
                _polyhedron.Translate(dPoint.X, dPoint.Y, dPoint.Z);
            }

            UpdateScene();
        }

        private bool _scale_mode = false;
        private void label9_Click(object sender, EventArgs e)
        {
            _scale_mode = !_scale_mode;
            if (_scale_mode)
            {
                (sender as Label).Text = "Scale";
            }
            else
            {
                (sender as Label).Text = "Center Scale";
            }
        }
    }
}
