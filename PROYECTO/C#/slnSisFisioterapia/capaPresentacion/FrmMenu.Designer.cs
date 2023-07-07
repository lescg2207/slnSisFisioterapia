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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnconfig = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbAdmin = new System.Windows.Forms.Panel();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pEnfermera = new System.Windows.Forms.Panel();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.pbDoctor = new System.Windows.Forms.Panel();
            this.btnHorario = new System.Windows.Forms.Button();
            this.btnReceta = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMesAño = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.frmContenedor = new System.Windows.Forms.Panel();
            this.fechaHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pbAdmin.SuspendLayout();
            this.pEnfermera.SuspendLayout();
            this.pbDoctor.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pbAdmin);
            this.panel1.Controls.Add(this.pEnfermera);
            this.panel1.Controls.Add(this.pbDoctor);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 788);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnconfig);
            this.panel7.Controls.Add(this.btnLogout);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 665);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(80, 123);
            this.panel7.TabIndex = 0;
            // 
            // btnconfig
            // 
            this.btnconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnconfig.FlatAppearance.BorderSize = 0;
            this.btnconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfig.Image = global::capaPresentacion.Properties.Resources.configuraciones__1_;
            this.btnconfig.Location = new System.Drawing.Point(0, -5);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(80, 64);
            this.btnconfig.TabIndex = 1;
            this.btnconfig.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(0, 59);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 64);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pbAdmin
            // 
            this.pbAdmin.Controls.Add(this.btnEmpleado);
            this.pbAdmin.Controls.Add(this.btnProductos);
            this.pbAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbAdmin.Location = new System.Drawing.Point(0, 533);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(80, 157);
            this.pbAdmin.TabIndex = 4;
            this.pbAdmin.Visible = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Image = global::capaPresentacion.Properties.Resources.user;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 64);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(80, 64);
            this.btnEmpleado.TabIndex = 1;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Image = global::capaPresentacion.Properties.Resources.productos;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(80, 64);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // pEnfermera
            // 
            this.pEnfermera.Controls.Add(this.btnCitas);
            this.pEnfermera.Controls.Add(this.btnPacientes);
            this.pEnfermera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEnfermera.Location = new System.Drawing.Point(0, 381);
            this.pEnfermera.Name = "pEnfermera";
            this.pEnfermera.Size = new System.Drawing.Size(80, 152);
            this.pEnfermera.TabIndex = 3;
            this.pEnfermera.Visible = false;
            // 
            // btnCitas
            // 
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Image = global::capaPresentacion.Properties.Resources.citas;
            this.btnCitas.Location = new System.Drawing.Point(0, 64);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(80, 64);
            this.btnCitas.TabIndex = 1;
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Image = global::capaPresentacion.Properties.Resources.user;
            this.btnPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(80, 64);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPacientes.UseVisualStyleBackColor = true;
            // 
            // pbDoctor
            // 
            this.pbDoctor.Controls.Add(this.btnHorario);
            this.pbDoctor.Controls.Add(this.btnReceta);
            this.pbDoctor.Controls.Add(this.btnDash);
            this.pbDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbDoctor.Location = new System.Drawing.Point(0, 172);
            this.pbDoctor.Name = "pbDoctor";
            this.pbDoctor.Size = new System.Drawing.Size(80, 209);
            this.pbDoctor.TabIndex = 2;
            this.pbDoctor.Visible = false;
            // 
            // btnHorario
            // 
            this.btnHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Image = global::capaPresentacion.Properties.Resources.horario;
            this.btnHorario.Location = new System.Drawing.Point(0, 128);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(80, 64);
            this.btnHorario.TabIndex = 2;
            this.btnHorario.UseVisualStyleBackColor = true;
            // 
            // btnReceta
            // 
            this.btnReceta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceta.FlatAppearance.BorderSize = 0;
            this.btnReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceta.Image = global::capaPresentacion.Properties.Resources.receta;
            this.btnReceta.Location = new System.Drawing.Point(0, 64);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(80, 64);
            this.btnReceta.TabIndex = 1;
            this.btnReceta.UseVisualStyleBackColor = true;
            // 
            // btnDash
            // 
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Image = global::capaPresentacion.Properties.Resources.home_;
            this.btnDash.Location = new System.Drawing.Point(0, 0);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(80, 64);
            this.btnDash.TabIndex = 0;
            this.btnDash.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(80, 74);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 98);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::capaPresentacion.Properties.Resources.log_bl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(80, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(80, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1120, 68);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::capaPresentacion.Properties.Resources.fond1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Controls.Add(this.lblMesAño);
            this.panel4.Controls.Add(this.lblDia);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Location = new System.Drawing.Point(819, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 42);
            this.panel4.TabIndex = 27;
            // 
            // lblMesAño
            // 
            this.lblMesAño.AutoSize = true;
            this.lblMesAño.BackColor = System.Drawing.Color.Transparent;
            this.lblMesAño.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMesAño.Location = new System.Drawing.Point(159, 12);
            this.lblMesAño.Name = "lblMesAño";
            this.lblMesAño.Size = new System.Drawing.Size(83, 17);
            this.lblMesAño.TabIndex = 3;
            this.lblMesAño.Text = "julio de 2023";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDia.Location = new System.Drawing.Point(143, 12);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(22, 17);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "02";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(65, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(62, 17);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "19:17 PM";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = global::capaPresentacion.Properties.Resources.calendario__1_;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel10.Location = new System.Drawing.Point(17, 7);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(35, 26);
            this.panel10.TabIndex = 0;
            // 
            // frmContenedor
            // 
            this.frmContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmContenedor.Location = new System.Drawing.Point(80, 98);
            this.frmContenedor.Name = "frmContenedor";
            this.frmContenedor.Size = new System.Drawing.Size(1120, 690);
            this.frmContenedor.TabIndex = 3;
            // 
            // fechaHora
            // 
            this.fechaHora.Enabled = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.frmContenedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pbAdmin.ResumeLayout(false);
            this.pEnfermera.ResumeLayout(false);
            this.pbDoctor.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel frmContenedor;
        private Button btnPacientes;
        private Panel panel4;
        private Panel panel10;
        private Label lblMesAño;
        private Label lblDia;
        private Label lblHora;
        private System.Windows.Forms.Timer fechaHora;
        public Panel pEnfermera;
        private Button btnCitas;
        private Button btnDash;
        private Button btnHorario;
        private Button btnReceta;
        private Button btnProductos;
        public Panel pbAdmin;
        public Panel pbDoctor;
        private Panel panel7;
        private Button btnLogout;
        private Button btnconfig;
        private Button btnEmpleado;
    }
}