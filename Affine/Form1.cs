using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Windows.Forms;

namespace Affine
{

    public enum Axis { AXIS_X, AXIS_Y, AXIS_Z, LINE };
    public enum Projection { PERSPECTIVE = 0, ISOMETRIC, ORTHOGR_X, ORTHOGR_Y, ORTHOGR_Z };
    public enum Clipping { Clipp = 0, ZBuffer, Gouraud, Texture, Graph};

    public partial class Form1 : Form
    {
        Graphics g;
        Projection projection = 0;
        Polyhedron figure = null;

        Clipping clipping = 0;

        //Camera camera = new Camera(50, 50);
        Camera camera = new Camera(
            new Point(0, 0, -500),
            (p) => new PointF(p.X,p.Y));
        Graphics graphics2;
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = pictureBox1.CreateGraphics();
            g.TranslateTransform(pictureBox1.ClientSize.Width / 2, pictureBox1.ClientSize.Height / 2);
            g.ScaleTransform(1, -1);

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            pictureBox2.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics2 = pictureBox2.CreateGraphics();
            graphics2.TranslateTransform(pictureBox1.ClientSize.Width / 2, pictureBox1.ClientSize.Height / 2);
            graphics2.ScaleTransform(1, -1);

        }

        private bool isStart = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
            isStart = !isStart;
            
        }

        //Рисование фигуры
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            isStart = !isStart;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //Татраэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Tetrahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    break;
                case 1:
                    //Гексаэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Hexahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    break;
                case 2:
                    //Октаэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Octahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    break;
                case 3:
                    //Икосаэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Icosahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    break;
                case 4:
                    //Додекаэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Dodecahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    break;
                default:
                    break;
            }
        }        

        private void Form1_MouseDown(object sender, MouseEventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (figure != null)
            { 
                //поворот
                int rotateAngleX = (int)numericUpDown4.Value;
                figure.Rotate(rotateAngleX, 0);

                int rotateAngleY = (int)numericUpDown5.Value;
                figure.Rotate(rotateAngleY, Axis.AXIS_Y);

                int rotateAngleZ = (int)numericUpDown6.Value;
                figure.Rotate(rotateAngleZ, Axis.AXIS_Z);
            }

            g.Clear(Color.White);
            if (clipping == 0)
                figure.Show(g, projection);
            graphics2.Clear(Color.White);
            figure.Show(graphics2, camera);
            //camera.show(g, projection);
        }

        
        private void Qbutton_MouseDown(object sender, MouseEventArgs e)
        {
            int step = 5;
            switch ((sender as Button).Text)
            {
                case "W":
                    camera.Position.Translate(step, 0, 0);
                    break;
                case "S":
                    camera.Position.Translate(-step, 0, 0);
                    break;
                case "A":
                    camera.Position.Translate(0, step, 0);
                    break;
                case "D":
                    camera.Position.Translate(0, -step, 0);
                    break;
                case "Q":
                    camera.Position.Translate(0, 0, step);
                    break;
                case "E":
                    camera.Position.Translate(0, 0, -step);
                    break;
                default:
                    break;
            }
            graphics2.Clear(Color.White);
            figure.Show(graphics2, camera);
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int step = 5;
            MessageBox.Show(e.KeyChar+"");
            switch (e.KeyChar)
            {
                case 'W':
                    camera.Position.Translate(step, 0, 0);
                    break;
                case 'S':
                    camera.Position.Translate(-step, 0, 0);
                    break;
                case 'A':
                    camera.Position.Translate(0, step, 0);
                    break;
                case 'D':
                    camera.Position.Translate(0, -step, 0);
                    break;
                case 'Q':
                    camera.Position.Translate(0, 0, step);
                    break;
                case 'E':
                    camera.Position.Translate(0, 0, -step);
                    break;
                default:
                    break;
            }
            e.Handled = true;
            graphics2.Clear(Color.White);
            figure.Show(graphics2, camera);
        }
        private void CameraRotation(object sender, MouseEventArgs e)
        {
            int step = 1;
            switch ((sender as Button).Text)
            {
                case "W":
                    camera.ViewRotate(step, 0, 0);
                    break;
                case "S":
                    camera.ViewRotate(-step, 0, 0);
                    break;
                case "A":
                    camera.ViewRotate(0, step, 0);
                    break;
                case "D":
                    camera.ViewRotate(0, -step, 0);
                    break;
                case "Q":
                    camera.ViewRotate(0, 0, step);
                    break;
                case "E":
                    camera.ViewRotate(0, 0, -step);
                    break;
                default:
                    break;
            }
            graphics2.Clear(Color.White);
            figure.Show(graphics2, camera);
            
            
        }

        float tick;
        float radius = 500;
        private void timer2_Tick(object sender, EventArgs e)
        {        
            
            camera.Position.SetValues(radius * (float)Math.Cos(tick), camera.Position.Y, radius * (float)Math.Sin(tick));
            camera.ViewRotate(0, 5.665f, 0);
            tick += 0.1f;

            graphics2.Clear(Color.White);
            figure.Show(graphics2, camera);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!timer2.Enabled)
            {
                timer2.Start();
                tick = 1.5f * (float)Math.PI;
            }
            else
            {
                timer2.Stop();
            }
            isStart = !isStart;
        }
    }
}