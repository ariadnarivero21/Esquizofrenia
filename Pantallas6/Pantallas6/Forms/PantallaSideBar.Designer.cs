namespace Pantallas6.Forms
{
    partial class PantallaSideBar
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
            btnReservacion = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnMinimize = new PictureBox();
            label1 = new Label();
            btnClose = new PictureBox();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 25, 28);
            panel1.Controls.Add(btnReservacion);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 870);
            panel1.TabIndex = 0;
            // 
            // btnReservacion
            // 
            btnReservacion.BackColor = Color.FromArgb(30, 33, 38);
            btnReservacion.FlatStyle = FlatStyle.Popup;
            btnReservacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservacion.ForeColor = SystemColors.ButtonHighlight;
            btnReservacion.Location = new Point(0, 280);
            btnReservacion.Margin = new Padding(4, 5, 4, 5);
            btnReservacion.Name = "btnReservacion";
            btnReservacion.Size = new Size(323, 72);
            btnReservacion.TabIndex = 7;
            btnReservacion.Text = "Reservación";
            btnReservacion.UseVisualStyleBackColor = false;
            btnReservacion.Click += btnReservacion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.esquizofrenia;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(96, 60);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 98);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 25, 28);
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(323, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1346, 55);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = Properties.Resources.minize;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Location = new Point(1261, 12);
            btnMinimize.Margin = new Padding(4, 5, 4, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(36, 38);
            btnMinimize.TabIndex = 4;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(636, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 5;
            label1.Text = "Esquizofrenia";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(1306, 12);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 38);
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Gray;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.ForeColor = Color.CadetBlue;
            panelContenedor.Location = new Point(323, 55);
            panelContenedor.Margin = new Padding(4, 5, 4, 5);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1346, 815);
            panelContenedor.TabIndex = 2;
            // 
            // PantallaSideBar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1669, 870);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "PantallaSideBar";
            Text = "PantallaSideBar";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnReservacion;
        private Panel panelContenedor;
        private PictureBox btnMinimize;
        private PictureBox btnClose;
    }
}