namespace capaPresentacion
{
    partial class FrmPaciente
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
            txtDniPaciente = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtCelular = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtAntecedentes = new TextBox();
            txtPeso = new TextBox();
            txtTalla = new TextBox();
            txtImc = new TextBox();
            pbxConsurDni = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            panel3 = new Panel();
            lbltitulo = new Label();
            btnSalir = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxConsurDni).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtDniPaciente
            // 
            txtDniPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniPaciente.Location = new Point(107, 46);
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.Size = new Size(142, 23);
            txtDniPaciente.TabIndex = 2;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(107, 90);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(142, 23);
            txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(107, 135);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(142, 23);
            txtApellidos.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(374, 85);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(142, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtCelular
            // 
            txtCelular.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.Location = new Point(374, 135);
            txtCelular.MaxLength = 9;
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(142, 23);
            txtCelular.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(374, 44);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(142, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // txtAntecedentes
            // 
            txtAntecedentes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAntecedentes.Location = new Point(136, 55);
            txtAntecedentes.Multiline = true;
            txtAntecedentes.Name = "txtAntecedentes";
            txtAntecedentes.Size = new Size(380, 53);
            txtAntecedentes.TabIndex = 10;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(82, 135);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(99, 23);
            txtPeso.TabIndex = 11;
            txtPeso.TextChanged += txtPeso_TextChanged;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // txtTalla
            // 
            txtTalla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTalla.Location = new Point(255, 134);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(99, 23);
            txtTalla.TabIndex = 12;
            txtTalla.TextChanged += txtTalla_TextChanged;
            txtTalla.KeyPress += txtTalla_KeyPress;
            // 
            // txtImc
            // 
            txtImc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtImc.Location = new Point(417, 134);
            txtImc.Name = "txtImc";
            txtImc.Size = new Size(99, 23);
            txtImc.TabIndex = 13;
            // 
            // pbxConsurDni
            // 
            pbxConsurDni.Cursor = Cursors.Hand;
            pbxConsurDni.Image = Properties.Resources.lupa;
            pbxConsurDni.Location = new Point(255, 46);
            pbxConsurDni.Name = "pbxConsurDni";
            pbxConsurDni.Size = new Size(23, 23);
            pbxConsurDni.SizeMode = PictureBoxSizeMode.Zoom;
            pbxConsurDni.TabIndex = 15;
            pbxConsurDni.TabStop = false;
            pbxConsurDni.Click += pbxConsurDni_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 49);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 16;
            label1.Text = "Dni :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 91);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 17;
            label2.Text = "Nombres :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 135);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 18;
            label3.Text = "Apellidos :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(294, 86);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 19;
            label4.Text = "Direccion :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(373, 136);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 23;
            label5.Text = "Imc :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(204, 136);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 22;
            label6.Text = "Talla :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(31, 136);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 21;
            label7.Text = "Peso :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(31, 68);
            label8.Name = "label8";
            label8.Size = new Size(99, 17);
            label8.TabIndex = 20;
            label8.Text = "Antecedentes :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(309, 136);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 24;
            label9.Text = "Celular :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(330, 48);
            label11.Name = "label11";
            label11.Size = new Size(36, 17);
            label11.TabIndex = 26;
            label11.Text = "F.N :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtDniPaciente);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(pbxConsurDni);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(34, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 195);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtImc);
            groupBox2.Controls.Add(txtAntecedentes);
            groupBox2.Controls.Add(txtPeso);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTalla);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(34, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(564, 195);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Clinicos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 173, 138);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 589);
            panel2.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(21, 60, 77);
            panel3.Controls.Add(lbltitulo);
            panel3.Location = new Point(34, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 53);
            panel3.TabIndex = 31;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.White;
            lbltitulo.Location = new Point(15, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(166, 30);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Nuevo Paciente";
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(489, 529);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(109, 30);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "Cerrar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(364, 529);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 30);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 585);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbxConsurDni).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbxConsurDni;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel2;
        private Panel panel3;
        private Button btnSalir;
        private Button btnGuardar;
        private Label lbltitulo;
        public TextBox txtDniPaciente;
        public TextBox txtNombres;
        public TextBox txtApellidos;
        public TextBox txtDireccion;
        public TextBox txtCelular;
        public DateTimePicker dtpFechaNacimiento;
        public TextBox txtAntecedentes;
        public TextBox txtPeso;
        public TextBox txtTalla;
        public TextBox txtImc;
    }
}