﻿namespace sistemaCompra
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            bienvenido = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(84, 261);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(336, 52);
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 51);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 350);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(160, 44);
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(440, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = ImeMode.NoControl;
            pictureBox5.Location = new Point(472, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(120, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 51);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // bienvenido
            // 
            bienvenido.AutoSize = true;
            bienvenido.Font = new Font("Gill Sans MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            bienvenido.ForeColor = Color.Black;
            bienvenido.Location = new Point(105, 56);
            bienvenido.Name = "bienvenido";
            bienvenido.Size = new Size(315, 47);
            bienvenido.TabIndex = 17;
            bienvenido.Text = "Bienvenido, admin";
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 412);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(bienvenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private Label bienvenido;
    }
}