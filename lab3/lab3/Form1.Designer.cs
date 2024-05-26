namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(87, 179);
            label1.Name = "label1";
            label1.Size = new Size(116, 26);
            label1.TabIndex = 3;
            label1.Text = "f(a)f(b) < 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(303, 24);
            label2.Name = "label2";
            label2.Size = new Size(235, 33);
            label2.TabIndex = 4;
            label2.Text = "Исходная функция";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(75, 206);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(142, 28);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(314, 150);
            label3.Name = "label3";
            label3.Size = new Size(175, 55);
            label3.TabIndex = 8;
            label3.Text = "f′(x)≠0, f′′(x)≠0 при x∈(a,b)";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(594, 177);
            label4.Name = "label4";
            label4.Size = new Size(134, 26);
            label4.TabIndex = 9;
            label4.Text = "f(x0)f′′(x0)>0";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(329, 206);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(142, 28);
            textBox4.TabIndex = 10;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(589, 206);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(142, 28);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 11.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(288, 258);
            label5.Name = "label5";
            label5.Size = new Size(173, 49);
            label5.TabIndex = 13;
            label5.Text = "Количество итераций";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(293, 367);
            button1.Name = "button1";
            button1.Size = new Size(216, 59);
            button1.TabIndex = 14;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(12, 30);
            label6.Name = "label6";
            label6.Size = new Size(24, 26);
            label6.TabIndex = 15;
            label6.Text = "a";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(12, 68);
            label7.Name = "label7";
            label7.Size = new Size(24, 26);
            label7.TabIndex = 16;
            label7.Text = "b";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(12, 106);
            label8.Name = "label8";
            label8.Size = new Size(34, 26);
            label8.TabIndex = 21;
            label8.Text = "x0";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ButtonHighlight;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(52, 105);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(57, 28);
            textBox6.TabIndex = 22;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(52, 67);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(57, 28);
            textBox3.TabIndex = 23;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonHighlight;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(52, 29);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(57, 28);
            textBox5.TabIndex = 24;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ButtonHighlight;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(303, 308);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(63, 28);
            textBox7.TabIndex = 25;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ButtonHighlight;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(475, 308);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(63, 28);
            textBox8.TabIndex = 26;
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 11.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(467, 283);
            label9.Name = "label9";
            label9.Size = new Size(71, 22);
            label9.TabIndex = 27;
            label9.Text = "Корень";
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ButtonHighlight;
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(621, 308);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(63, 28);
            textBox9.TabIndex = 28;
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.Font = new Font("Times New Roman", 11.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(571, 256);
            label10.Name = "label10";
            label10.Size = new Size(170, 51);
            label10.TabIndex = 29;
            label10.Text = "Значение функции в корне";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.ButtonFace;
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(52, 141);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(57, 28);
            textBox10.TabIndex = 31;
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(12, 141);
            label11.Name = "label11";
            label11.Size = new Size(43, 26);
            label11.TabIndex = 30;
            label11.Text = "eps";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.b_9q_0fGRJk;
            pictureBox1.Location = new Point(188, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 64);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2JcMoqcso5A;
            pictureBox2.Location = new Point(27, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 118);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox10);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lab3 ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}