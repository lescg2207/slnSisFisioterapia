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
            btnInsertar = new Button();
            txtDniPaciente = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtCelular = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnActualizar = new Button();
            dgvPaciente = new DataGridView();
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
            btnLimpiar = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label12 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxConsurDni).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(922, 31);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(135, 35);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "GUARDAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
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
            // btnActualizar
            // 
            btnActualizar.Location = new Point(781, 31);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(135, 35);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvPaciente
            // 
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.Location = new Point(51, 83);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.RowTemplate.Height = 25;
            dgvPaciente.Size = new Size(1006, 304);
            dgvPaciente.TabIndex = 9;
            dgvPaciente.CellClick += dgvPaciente_CellClick;
            // 
            // txtAntecedentes
            // 
            txtAntecedentes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAntecedentes.Location = new Point(136, 55);
            txtAntecedentes.Multiline = true;
            txtAntecedentes.Name = "txtAntecedentes";
            txtAntecedentes.Size = new Size(250, 53);
            txtAntecedentes.TabIndex = 10;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(31, 134);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(99, 23);
            txtPeso.TabIndex = 11;
            // 
            // txtTalla
            // 
            txtTalla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTalla.Location = new Point(157, 135);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(99, 23);
            txtTalla.TabIndex = 12;
            // 
            // txtImc
            // 
            txtImc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtImc.Location = new Point(287, 135);
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
            label5.Location = new Point(287, 115);
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
            label6.Location = new Point(157, 115);
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
            label7.Location = new Point(31, 114);
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
            groupBox1.Location = new Point(51, 35);
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
            groupBox2.Location = new Point(644, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 195);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Clinicos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(640, 31);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(135, 35);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 30;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(66, 39);
            label12.Name = "label12";
            label12.Size = new Size(101, 17);
            label12.TabIndex = 24;
            label12.Text = "Búsqueda por :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 60, 77);
            panel1.Controls.Add(dgvPaciente);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnInsertar);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnLimpiar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 422);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 173, 138);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 268);
            panel2.TabIndex = 33;
            // 
            // FrmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 690);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPaciente";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxConsurDni).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertar;
        private TextBox txtDniPaciente;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtDireccion;
        private TextBox txtCelular;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnActualizar;
        private DataGridView dgvPaciente;
        private TextBox txtAntecedentes;
        private TextBox txtPeso;
        private TextBox txtTalla;
        private TextBox txtImc;
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
        private Button btnLimpiar;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label12;
        private Panel panel1;
        private Panel panel2;
    }
}