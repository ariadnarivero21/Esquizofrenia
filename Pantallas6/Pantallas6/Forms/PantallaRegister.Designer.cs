namespace Pantallas6.Forms
{
    partial class PantallaRegister
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
            panel1 = new Panel();
            label4 = new Label();
            textBox3 = new TextBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 25, 28);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(141, 67);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(603, 427);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(145, 170);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 12;
            label4.Text = "Correo electronico";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(30, 33, 38);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.HighlightText;
            textBox3.Location = new Point(145, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 22);
            textBox3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 33, 38);
            panel4.Location = new Point(145, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 45);
            panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.esquizofrenia;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(241, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 59);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(313, 369);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Haz click aqui";
            linkLabel1.VisitedLinkColor = Color.DodgerBlue;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(201, 369);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 7;
            label3.Text = "¿Tenes una cuenta?";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(145, 323);
            button1.Name = "button1";
            button1.Size = new Size(297, 43);
            button1.TabIndex = 6;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(145, 241);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(145, 102);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 4;
            label1.Text = "Nombre de usuario";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 33, 38);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.HighlightText;
            textBox2.Location = new Point(145, 272);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 22);
            textBox2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 33, 38);
            panel3.Location = new Point(145, 261);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 45);
            panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 33, 38);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.HighlightText;
            textBox1.Location = new Point(145, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 22);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 33, 38);
            panel2.Location = new Point(145, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 45);
            panel2.TabIndex = 1;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = Properties.Resources.minize;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Location = new Point(826, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 23);
            btnMinimize.TabIndex = 4;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(857, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 23);
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // PantallaRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(884, 561);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRegister";
            Text = "PantallaRegister";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox textBox3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Panel panel3;
        private TextBox textBox1;
        private Panel panel2;
        private PictureBox btnMinimize;
        private PictureBox btnClose;
    }
}