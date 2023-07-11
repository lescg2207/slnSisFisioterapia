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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panel1 = new Panel();
            btnTree = new Button();
            btnEmpleado = new Button();
            btnProductos = new Button();
            btnCita = new Button();
            btnPaciente = new Button();
            btnDash = new Button();
            panel7 = new Panel();
            btnconfig = new Button();
            btnLogout = new Button();
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
            frmContenedor = new Panel();
            fechaHora = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 60, 77);
            panel1.Controls.Add(btnTree);
            panel1.Controls.Add(btnEmpleado);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnCita);
            panel1.Controls.Add(btnPaciente);
            panel1.Controls.Add(btnDash);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 788);
            panel1.TabIndex = 0;
            // 
            // btnTree
            // 
            btnTree.Cursor = Cursors.Hand;
            btnTree.Dock = DockStyle.Top;
            btnTree.FlatAppearance.BorderSize = 0;
            btnTree.FlatStyle = FlatStyle.Flat;
            btnTree.Image = Properties.Resources.configuraciones__1_;
            btnTree.Location = new Point(0, 468);
            btnTree.Name = "btnTree";
            btnTree.Size = new Size(80, 64);
            btnTree.TabIndex = 7;
            btnTree.UseVisualStyleBackColor = true;
            btnTree.Visible = false;
            btnTree.Click += btnTree_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Cursor = Cursors.Hand;
            btnEmpleado.Dock = DockStyle.Top;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Image = Properties.Resources.empleado;
            btnEmpleado.Location = new Point(0, 404);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(80, 64);
            btnEmpleado.TabIndex = 6;
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Visible = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Image = Properties.Resources.caja;
            btnProductos.Location = new Point(0, 340);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(80, 64);
            btnProductos.TabIndex = 5;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Visible = false;
            btnProductos.Click += btnProductos_Click_1;
            // 
            // btnCita
            // 
            btnCita.Cursor = Cursors.Hand;
            btnCita.Dock = DockStyle.Top;
            btnCita.FlatAppearance.BorderSize = 0;
            btnCita.FlatStyle = FlatStyle.Flat;
            btnCita.Image = Properties.Resources.calendario__2_;
            btnCita.Location = new Point(0, 276);
            btnCita.Name = "btnCita";
            btnCita.Size = new Size(80, 64);
            btnCita.TabIndex = 3;
            btnCita.UseVisualStyleBackColor = true;
            btnCita.Visible = false;
            btnCita.Click += btnCitas_Click;
            // 
            // btnPaciente
            // 
            btnPaciente.Cursor = Cursors.Hand;
            btnPaciente.Dock = DockStyle.Top;
            btnPaciente.FlatAppearance.BorderSize = 0;
            btnPaciente.FlatStyle = FlatStyle.Flat;
            btnPaciente.Image = Properties.Resources.paciente;
            btnPaciente.Location = new Point(0, 212);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(80, 64);
            btnPaciente.TabIndex = 2;
            btnPaciente.UseVisualStyleBackColor = true;
            btnPaciente.Visible = false;
            btnPaciente.Click += btnPacientes_Click;
            // 
            // btnDash
            // 
            btnDash.Cursor = Cursors.Hand;
            btnDash.Dock = DockStyle.Top;
            btnDash.FlatAppearance.BorderSize = 0;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Image = Properties.Resources.home_;
            btnDash.Location = new Point(0, 148);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(80, 64);
            btnDash.TabIndex = 0;
            btnDash.UseVisualStyleBackColor = true;
            btnDash.Visible = false;
            btnDash.Click += btnDash_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnconfig);
            panel7.Controls.Add(btnLogout);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 665);
            panel7.Name = "panel7";
            panel7.Size = new Size(80, 123);
            panel7.TabIndex = 0;
            // 
            // btnconfig
            // 
            btnconfig.Cursor = Cursors.Hand;
            btnconfig.Dock = DockStyle.Bottom;
            btnconfig.FlatAppearance.BorderSize = 0;
            btnconfig.FlatStyle = FlatStyle.Flat;
            btnconfig.Location = new Point(0, -5);
            btnconfig.Name = "btnconfig";
            btnconfig.Size = new Size(80, 64);
            btnconfig.TabIndex = 1;
            btnconfig.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(0, 59);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 64);
            btnLogout.TabIndex = 0;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
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
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 173, 138);
            panel3.Controls.Add(panel4);
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
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel frmContenedor;
        private Panel panel4;
        private Panel panel10;
        private Label lblMesAño;
        private Label lblDia;
        private Label lblHora;
        private System.Windows.Forms.Timer fechaHora;
        private Panel panel7;
        private Button btnLogout;
        private Button btnconfig;
        private Button btnDash;
        private Button btnPaciente;
        private Button btnTree;
        private Button btnEmpleado;
        private Button btnProductos;
        private Button btnCita;
    }
}