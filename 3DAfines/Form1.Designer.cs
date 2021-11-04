
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
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.point2Z = new System.Windows.Forms.TextBox();
            this.point2Y = new System.Windows.Forms.TextBox();
            this.point2X = new System.Windows.Forms.TextBox();
            this.point1Z = new System.Windows.Forms.TextBox();
            this.point1Y = new System.Windows.Forms.TextBox();
            this.point1X = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 436);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(14, 459);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 461);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(468, 34);
            this.vScrollBar1.Maximum = 500;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DXScroll_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(505, 34);
            this.vScrollBar2.Maximum = 500;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar2.TabIndex = 4;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DYScroll_Scroll);
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(542, 34);
            this.vScrollBar3.Maximum = 500;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar3.TabIndex = 5;
            this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DZScroll_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "dx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "dy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "dz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Translate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rotate";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 29);
            this.label6.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 84;
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(683, 34);
            this.vScrollBar4.Maximum = 360;
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar4.TabIndex = 16;
            this.vScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DZRotate_Scroll);
            // 
            // vScrollBar5
            // 
            this.vScrollBar5.Location = new System.Drawing.Point(646, 34);
            this.vScrollBar5.Maximum = 360;
            this.vScrollBar5.Name = "vScrollBar5";
            this.vScrollBar5.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar5.TabIndex = 15;
            this.vScrollBar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DYRotate_Scroll);
            // 
            // vScrollBar6
            // 
            this.vScrollBar6.Location = new System.Drawing.Point(609, 34);
            this.vScrollBar6.Maximum = 360;
            this.vScrollBar6.Name = "vScrollBar6";
            this.vScrollBar6.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar6.TabIndex = 14;
            this.vScrollBar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DXRotate_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(780, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Scale";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(842, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "dz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(804, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "dy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(767, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "dx";
            // 
            // vScrollBar7
            // 
            this.vScrollBar7.Location = new System.Drawing.Point(843, 34);
            this.vScrollBar7.Minimum = -100;
            this.vScrollBar7.Name = "vScrollBar7";
            this.vScrollBar7.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar7.TabIndex = 23;
            this.vScrollBar7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DZScale_Scroll);
            // 
            // vScrollBar8
            // 
            this.vScrollBar8.Location = new System.Drawing.Point(806, 34);
            this.vScrollBar8.Minimum = -100;
            this.vScrollBar8.Name = "vScrollBar8";
            this.vScrollBar8.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar8.TabIndex = 22;
            this.vScrollBar8.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DYScale_Scroll);
            // 
            // vScrollBar9
            // 
            this.vScrollBar9.Location = new System.Drawing.Point(768, 34);
            this.vScrollBar9.Minimum = -100;
            this.vScrollBar9.Name = "vScrollBar9";
            this.vScrollBar9.Size = new System.Drawing.Size(21, 154);
            this.vScrollBar9.TabIndex = 21;
            this.vScrollBar9.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DXScale_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "Tetrahedron";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(969, 66);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 44);
            this.button2.TabIndex = 29;
            this.button2.Text = "Hexahedron";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(969, 118);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 44);
            this.button3.TabIndex = 30;
            this.button3.Text = "Octahedron";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(969, 169);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 44);
            this.button4.TabIndex = 31;
            this.button4.Text = "Icosahedron";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(969, 220);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 44);
            this.button5.TabIndex = 32;
            this.button5.Text = "Dodecahedron";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(539, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 18);
            this.label20.TabIndex = 78;
            this.label20.Text = "Z";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(539, 309);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 18);
            this.label19.TabIndex = 77;
            this.label19.Text = "Y";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(539, 271);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 18);
            this.label18.TabIndex = 76;
            this.label18.Text = "X";
            // 
            // point2Z
            // 
            this.point2Z.Location = new System.Drawing.Point(566, 344);
            this.point2Z.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.point2Z.Name = "point2Z";
            this.point2Z.Size = new System.Drawing.Size(64, 26);
            this.point2Z.TabIndex = 75;
            this.point2Z.Text = "0";
            // 
            // point2Y
            // 
            this.point2Y.Location = new System.Drawing.Point(566, 309);
            this.point2Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.point2Y.Name = "point2Y";
            this.point2Y.Size = new System.Drawing.Size(64, 26);
            this.point2Y.TabIndex = 74;
            this.point2Y.Text = "0";
            // 
            // point2X
            // 
            this.point2X.Location = new System.Drawing.Point(566, 271);
            this.point2X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.point2X.Name = "point2X";
            this.point2X.Size = new System.Drawing.Size(64, 26);
            this.point2X.TabIndex = 73;
            this.point2X.Text = "0";
            // 
            // point1Z
            // 
            this.point1Z.Location = new System.Drawing.Point(468, 344);
            this.point1Z.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.point1Z.Name = "point1Z";
            this.point1Z.Size = new System.Drawing.Size(64, 26);
            this.point1Z.TabIndex = 72;
            this.point1Z.Text = "0";
            // 
            // point1Y
            // 
            this.point1Y.Location = new System.Drawing.Point(468, 306);
            this.point1Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.point1Y.Name = "point1Y";
            this.point1Y.Size = new System.Drawing.Size(64, 26);
            this.point1Y.TabIndex = 71;
            this.point1Y.Text = "0";
            // 
            // point1X
            // 
            this.point1X.Location = new System.Drawing.Point(468, 271);
            this.point1X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.point1X.Name = "point1X";
            this.point1X.Size = new System.Drawing.Size(64, 26);
            this.point1X.TabIndex = 70;
            this.point1X.Text = "0";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(468, 391);
            this.hScrollBar1.Maximum = 360;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(162, 21);
            this.hScrollBar1.TabIndex = 79;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LineRotate);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(490, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 80;
            this.label13.Text = "Angle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Location = new System.Drawing.Point(683, 249);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(230, 235);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отражение";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(53, 146);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 35);
            this.button8.TabIndex = 35;
            this.button8.Text = "ReflectionXY";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(53, 58);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 35);
            this.button6.TabIndex = 33;
            this.button6.Text = "ReflectionYZ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(53, 101);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 35);
            this.button7.TabIndex = 34;
            this.button7.Text = "ReflectionZX";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(969, 284);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 51);
            this.button9.TabIndex = 85;
            this.button9.Text = "Загрузить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(969, 362);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(126, 50);
            this.button10.TabIndex = 86;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 935);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.point2Z);
            this.Controls.Add(this.point2Y);
            this.Controls.Add(this.point2X);
            this.Controls.Add(this.point1Z);
            this.Controls.Add(this.point1Y);
            this.Controls.Add(this.point1X);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox point2Z;
        private System.Windows.Forms.TextBox point2Y;
        private System.Windows.Forms.TextBox point2X;
        private System.Windows.Forms.TextBox point1Z;
        private System.Windows.Forms.TextBox point1Y;
        private System.Windows.Forms.TextBox point1X;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button10;
    }
}

