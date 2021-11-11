
namespace _3DAfines
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar5 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar6 = new System.Windows.Forms.VScrollBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vScrollBar7 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar8 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar9 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.vScrollBar10 = new System.Windows.Forms.VScrollBar();
            this.label13 = new System.Windows.Forms.Label();
            this.vScrollBar11 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar12 = new System.Windows.Forms.VScrollBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 349);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 367);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 369);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(416, 27);
            this.vScrollBar1.Maximum = 500;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DXScroll_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(449, 27);
            this.vScrollBar2.Maximum = 500;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar2.TabIndex = 4;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DYScroll_Scroll);
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(482, 27);
            this.vScrollBar3.Maximum = 500;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar3.TabIndex = 5;
            this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DZScroll_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "dx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "dy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "dz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Translate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rotate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "dz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "dy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "dx";
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(607, 27);
            this.vScrollBar4.Maximum = 360;
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar4.TabIndex = 16;
            this.vScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DZRotate_Scroll);
            // 
            // vScrollBar5
            // 
            this.vScrollBar5.Location = new System.Drawing.Point(574, 27);
            this.vScrollBar5.Maximum = 360;
            this.vScrollBar5.Name = "vScrollBar5";
            this.vScrollBar5.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar5.TabIndex = 15;
            this.vScrollBar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DYRotate_Scroll);
            // 
            // vScrollBar6
            // 
            this.vScrollBar6.Location = new System.Drawing.Point(541, 27);
            this.vScrollBar6.Maximum = 360;
            this.vScrollBar6.Name = "vScrollBar6";
            this.vScrollBar6.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar6.TabIndex = 14;
            this.vScrollBar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DXRotate_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(693, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Scale";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(748, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "dz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(715, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "dy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "dx";
            // 
            // vScrollBar7
            // 
            this.vScrollBar7.Location = new System.Drawing.Point(749, 27);
            this.vScrollBar7.Minimum = -100;
            this.vScrollBar7.Name = "vScrollBar7";
            this.vScrollBar7.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar7.TabIndex = 23;
            this.vScrollBar7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DZScale_Scroll);
            // 
            // vScrollBar8
            // 
            this.vScrollBar8.Location = new System.Drawing.Point(716, 27);
            this.vScrollBar8.Minimum = -100;
            this.vScrollBar8.Name = "vScrollBar8";
            this.vScrollBar8.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar8.TabIndex = 22;
            this.vScrollBar8.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DYScale_Scroll);
            // 
            // vScrollBar9
            // 
            this.vScrollBar9.Location = new System.Drawing.Point(683, 27);
            this.vScrollBar9.Minimum = -100;
            this.vScrollBar9.Name = "vScrollBar9";
            this.vScrollBar9.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar9.TabIndex = 21;
            this.vScrollBar9.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DXScale_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Tetrahedron";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(861, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 29;
            this.button2.Text = "Hexahedron";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(861, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 30;
            this.button3.Text = "Octahedron";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(861, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 31;
            this.button4.Text = "Icosahedron";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(861, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 32;
            this.button5.Text = "Dodecahedron";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // vScrollBar10
            // 
            this.vScrollBar10.Location = new System.Drawing.Point(416, 238);
            this.vScrollBar10.Maximum = 500;
            this.vScrollBar10.Name = "vScrollBar10";
            this.vScrollBar10.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar10.TabIndex = 33;
            this.vScrollBar10.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar10_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "RotateCentre";
            // 
            // vScrollBar11
            // 
            this.vScrollBar11.Location = new System.Drawing.Point(451, 238);
            this.vScrollBar11.Maximum = 500;
            this.vScrollBar11.Name = "vScrollBar11";
            this.vScrollBar11.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar11.TabIndex = 35;
            this.vScrollBar11.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar11_Scroll);
            // 
            // vScrollBar12
            // 
            this.vScrollBar12.Location = new System.Drawing.Point(484, 238);
            this.vScrollBar12.Maximum = 500;
            this.vScrollBar12.Name = "vScrollBar12";
            this.vScrollBar12.Size = new System.Drawing.Size(21, 123);
            this.vScrollBar12.TabIndex = 36;
            this.vScrollBar12.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar12_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(415, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "dx";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(448, 367);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "dy";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(482, 367);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "dz";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(538, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "RotateLine";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(694, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 17);
            this.label21.TabIndex = 50;
            this.label21.Text = "Line Params";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(861, 512);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 35);
            this.button6.TabIndex = 55;
            this.button6.Text = "Dodecahedron";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(861, 471);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 35);
            this.button7.TabIndex = 54;
            this.button7.Text = "Icosahedron";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(861, 430);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 35);
            this.button8.TabIndex = 53;
            this.button8.Text = "Octahedron";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(861, 389);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 35);
            this.button9.TabIndex = 52;
            this.button9.Text = "Hexahedron";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(861, 348);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(112, 35);
            this.button10.TabIndex = 51;
            this.button10.Text = "Tetrahedron";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(864, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 17);
            this.label18.TabIndex = 56;
            this.label18.Text = "Add Polyhedron";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(554, 316);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(112, 35);
            this.button11.TabIndex = 57;
            this.button11.Text = "Modify First";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(685, 316);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(112, 35);
            this.button12.TabIndex = 58;
            this.button12.Text = "Modify Second";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(639, 403);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 21);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "ZBuffer ON";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 748);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.vScrollBar12);
            this.Controls.Add(this.vScrollBar11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.vScrollBar10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.vScrollBar7);
            this.Controls.Add(this.vScrollBar8);
            this.Controls.Add(this.vScrollBar9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vScrollBar4);
            this.Controls.Add(this.vScrollBar5);
            this.Controls.Add(this.vScrollBar6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.VScrollBar vScrollBar5;
        private System.Windows.Forms.VScrollBar vScrollBar6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.VScrollBar vScrollBar7;
        private System.Windows.Forms.VScrollBar vScrollBar8;
        private System.Windows.Forms.VScrollBar vScrollBar9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.VScrollBar vScrollBar10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.VScrollBar vScrollBar11;
        private System.Windows.Forms.VScrollBar vScrollBar12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

