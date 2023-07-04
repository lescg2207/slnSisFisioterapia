namespace capaPresentacion
{
    partial class FrmMenu
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel9 = new Panel();
            pEnfermera = new Panel();
            btnPacientes = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblMesAño = new Label();
            lblDia = new Label();
            lblHora = new Label();
            panel10 = new Panel();
            lbltitulo = new Label();
            frmContenedor = new Panel();
            fechaHora = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            pEnfermera.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 60, 77);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(pEnfermera);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 788);
            panel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 489);
            panel9.Name = "panel9";
            panel9.Size = new Size(80, 100);
            panel9.TabIndex = 4;
            // 
            // pEnfermera
            // 
            pEnfermera.Controls.Add(btnPacientes);
            pEnfermera.Dock = DockStyle.Top;
            pEnfermera.Location = new Point(0, 295);
            pEnfermera.Name = "pEnfermera";
            pEnfermera.Size = new Size(80, 194);
            pEnfermera.TabIndex = 3;
            // 
            // btnPacientes
            // 
            btnPacientes.Cursor = Cursors.Hand;
            btnPacientes.Dock = DockStyle.Top;
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Image = Properties.Resources.user;
            btnPacientes.Location = new Point(0, 0);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(80, 64);
            btnPacientes.TabIndex = 0;
            btnPacientes.TextAlign = ContentAlignment.MiddleRight;
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 148);
            panel7.Name = "panel7";
            panel7.Size = new Size(80, 147);
            panel7.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 98);
            panel6.Name = "panel6";
            panel6.Size = new Size(80, 50);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(80, 98);
            panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.log_bl;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(21, 60, 77);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(80, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 30);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 173, 138);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lbltitulo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(80, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1120, 68);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.fond1;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Controls.Add(lblMesAño);
            panel4.Controls.Add(lblDia);
            panel4.Controls.Add(lblHora);
            panel4.Controls.Add(panel10);
            panel4.Location = new Point(819, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(274, 42);
            panel4.TabIndex = 27;
            // 
            // lblMesAño
            // 
            lblMesAño.AutoSize = true;
            lblMesAño.BackColor = Color.Transparent;
            lblMesAño.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMesAño.Location = new Point(159, 12);
            lblMesAño.Name = "lblMesAño";
            lblMesAño.Size = new Size(83, 17);
            lblMesAño.TabIndex = 3;
            lblMesAño.Text = "julio de 2023";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.BackColor = Color.Transparent;
            lblDia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDia.Location = new Point(143, 12);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(22, 17);
            lblDia.TabIndex = 2;
            lblDia.Text = "02";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(65, 12);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(62, 17);
            lblHora.TabIndex = 1;
            lblHora.Text = "19:17 PM";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.BackgroundImage = Properties.Resources.calendario__1_;
            panel10.BackgroundImageLayout = ImageLayout.Center;
            panel10.Location = new Point(17, 7);
            panel10.Name = "panel10";
            panel10.Size = new Size(35, 26);
            panel10.TabIndex = 0;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.White;
            lbltitulo.Location = new Point(25, 13);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(217, 37);
            lbltitulo.TabIndex = 26;
            lbltitulo.Text = "Nuevo Paciente";
            // 
            // frmContenedor
            // 
            frmContenedor.Dock = DockStyle.Fill;
            frmContenedor.Location = new Point(80, 98);
            frmContenedor.Name = "frmContenedor";
            frmContenedor.Size = new Size(1120, 690);
            frmContenedor.TabIndex = 3;
            // 
            // fechaHora
            // 
            fechaHora.Enabled = true;
            fechaHora.Tick += fechaHora_Tick;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 788);
            Controls.Add(frmContenedor);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            panel1.ResumeLayout(false);
            pEnfermera.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel9;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel frmContenedor;
        private Button btnPacientes;
        private Label lbltitulo;
        private Panel panel4;
        private Panel panel10;
        private Label lblMesAño;
        private Label lblDia;
        private Label lblHora;
        private System.Windows.Forms.Timer fechaHora;
        public Panel pEnfermera;
    }
}