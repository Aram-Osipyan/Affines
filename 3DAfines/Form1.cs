using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DAfines
{
    public partial class Form1 : Form
    {
        Graphics _graphics1;
        Graphics _graphics2;
        Polyhedron _polyhedron;
        Polyhedron _axes;
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
        private void button1_Click(object sender, EventArgs e)
        {
            _polyhedron.DrawParall(_graphics1, Pens.Black);
        }

        private void DXScroll_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Translate(e.NewValue - e.OldValue, 0, 0);
            UpdateScene();
        }
    
        private void DYScroll_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Translate(0,e.NewValue - e.OldValue, 0);
            UpdateScene();
        }
        private void DZScroll_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Translate( 0, 0,e.NewValue - e.OldValue);
            UpdateScene();
        }
        private void DXRotate_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Rotate(e.NewValue - e.OldValue, 0, 0);
            UpdateScene();
        }

        private void DYRotate_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Rotate(0,e.NewValue - e.OldValue, 0);
            UpdateScene();
        }
        private void DZRotate_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Rotate(0,0,e.NewValue - e.OldValue);
            UpdateScene();
        }

        private void DXScale_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Scale((float)(e.NewValue - e.OldValue) /100 +1, 1, 1);
            UpdateScene();
        }

        private void DYScale_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Scale(1, (float)(e.NewValue - e.OldValue) /100 +1 , 1);
            UpdateScene();
        }
        private void DZScale_Scroll(object sender, ScrollEventArgs e)
        {
            _polyhedron.Scale(1, 1, (float)(e.NewValue - e.OldValue) /100 + 1);
            UpdateScene();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            UpdateScene();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _polyhedron = Polyhedron.Tetrahedron(60);
            UpdateScene();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _polyhedron = Polyhedron.Hexahedron(60);
            UpdateScene();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _polyhedron = Polyhedron.Octahedron(60);
            UpdateScene();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _polyhedron = Polyhedron.Icosahedron(60);
            UpdateScene();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _polyhedron = Polyhedron.Dodecahedron(60);
            UpdateScene();
        }
    }
}
