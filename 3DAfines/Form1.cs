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
        Polyhedron _polyhedron2;
        Polyhedron _axes;
        bool modify_second = false;
        bool zBufferON = false;

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
            _polyhedron.DrawIso(_graphics2, Pens.Black);
            if (_polyhedron2 != null)
            {
                _polyhedron2.DrawIso(_graphics2, Pens.Blue);
                _polyhedron2.DrawParall(_graphics1, Pens.Blue);
            }
            if (zBufferON)
            {
                List<Polyhedron> polyhedrons = new List<Polyhedron>();
                polyhedrons.Add(_polyhedron);
                if (_polyhedron2 != null)
                {
                    polyhedrons.Add(_polyhedron2);
                }
                Bitmap bmp = ZBuffer.ApplyBuffer(pictureBox1.Width, pictureBox1.Height, polyhedrons);
                pictureBox1.Image = bmp;
            }
            else
            {
                _polyhedron.DrawParall(_graphics1, Pens.Black);
            }
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
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Translate(e.NewValue - e.OldValue, 0, 0);
            UpdateScene();
        }
    
        private void DYScroll_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Translate(0,e.NewValue - e.OldValue, 0);
            UpdateScene();
        }
        private void DZScroll_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Translate( 0, 0,e.NewValue - e.OldValue);
            UpdateScene();
        }
        private void DXRotate_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Rotate(e.NewValue - e.OldValue, 0, 0);
            UpdateScene();
        }

        private void DYRotate_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Rotate(0,e.NewValue - e.OldValue, 0);
            UpdateScene();
        }
        private void DZRotate_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Rotate(0,0,e.NewValue - e.OldValue);
            UpdateScene();
        }

        private void DXScale_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Scale((float)(e.NewValue - e.OldValue) /100 +1, 1, 1);
            UpdateScene();
        }

        private void DYScale_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Scale(1, (float)(e.NewValue - e.OldValue) /100 +1 , 1);
            UpdateScene();
        }
        private void DZScale_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            working.Scale(1, 1, (float)(e.NewValue - e.OldValue) /100 + 1);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar10_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            Point dPoint = working.GetCentralPoint();
            working.Translate(-dPoint.X, -dPoint.Y, -dPoint.Z);
            working.Rotate(e.NewValue - e.OldValue, 0, 0);
            working.Translate(dPoint.X, dPoint.Y, dPoint.Z);
            UpdateScene();
        }

        private void vScrollBar11_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            Point dPoint = working.GetCentralPoint();
            working.Translate(-dPoint.X, -dPoint.Y, -dPoint.Z);
            working.Rotate(0, e.NewValue - e.OldValue, 0);
            working.Translate(dPoint.X, dPoint.Y, dPoint.Z);
            UpdateScene();
        }

        private void vScrollBar12_Scroll(object sender, ScrollEventArgs e)
        {
            Polyhedron working = _polyhedron;
            if (modify_second)
            {
                working = _polyhedron2;
            }
            Point dPoint = working.GetCentralPoint();
            working.Translate(-dPoint.X, -dPoint.Y, -dPoint.Z);
            working.Rotate(0, 0, e.NewValue - e.OldValue);
            working.Translate(dPoint.X, dPoint.Y, dPoint.Z);
            UpdateScene();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _polyhedron2 = Polyhedron.Tetrahedron(60);
            UpdateScene();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _polyhedron2 = Polyhedron.Hexahedron(60);
            UpdateScene();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _polyhedron2 = Polyhedron.Octahedron(60);
            UpdateScene();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _polyhedron2 = Polyhedron.Icosahedron(60);
            UpdateScene();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _polyhedron2 = Polyhedron.Dodecahedron(60);
            UpdateScene();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            modify_second = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            modify_second = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            zBufferON = !zBufferON;
            UpdateScene();
        }
    }
}
