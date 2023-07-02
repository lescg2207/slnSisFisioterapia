namespace capaPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            txtObserva = new TextBox();
            pbxConsurDni = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxConsurDni).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(511, 30);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(135, 35);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "GUARDAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtDniPaciente
            // 
            txtDniPaciente.Location = new Point(41, 31);
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.Size = new Size(142, 23);
            txtDniPaciente.TabIndex = 2;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(41, 74);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(142, 23);
            txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(41, 119);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(142, 23);
            txtApellidos.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(41, 168);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(142, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(41, 218);
            txtCelular.MaxLength = 9;
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(142, 23);
            txtCelular.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(41, 267);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(142, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(511, 89);
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
            dgvPaciente.Location = new Point(41, 324);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.RowTemplate.Height = 25;
            dgvPaciente.Size = new Size(605, 244);
            dgvPaciente.TabIndex = 9;
            // 
            // txtAntecedentes
            // 
            txtAntecedentes.Location = new Point(270, 31);
            txtAntecedentes.Name = "txtAntecedentes";
            txtAntecedentes.Size = new Size(152, 23);
            txtAntecedentes.TabIndex = 10;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(270, 74);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(152, 23);
            txtPeso.TabIndex = 11;
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(270, 119);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(152, 23);
            txtTalla.TabIndex = 12;
            // 
            // txtImc
            // 
            txtImc.Location = new Point(270, 168);
            txtImc.Name = "txtImc";
            txtImc.Size = new Size(152, 23);
            txtImc.TabIndex = 13;
            // 
            // txtObserva
            // 
            txtObserva.Location = new Point(270, 218);
            txtObserva.Name = "txtObserva";
            txtObserva.Size = new Size(152, 23);
            txtObserva.TabIndex = 14;
            // 
            // pbxConsurDni
            // 
            pbxConsurDni.Cursor = Cursors.Hand;
            pbxConsurDni.Image = (Image)resources.GetObject("pbxConsurDni.Image");
            pbxConsurDni.Location = new Point(189, 30);
            pbxConsurDni.Name = "pbxConsurDni";
            pbxConsurDni.Size = new Size(41, 48);
            pbxConsurDni.TabIndex = 15;
            pbxConsurDni.TabStop = false;
            pbxConsurDni.Click += pbxConsurDni_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 623);
            Controls.Add(pbxConsurDni);
            Controls.Add(txtObserva);
            Controls.Add(txtImc);
            Controls.Add(txtTalla);
            Controls.Add(txtPeso);
            Controls.Add(txtAntecedentes);
            Controls.Add(dgvPaciente);
            Controls.Add(btnActualizar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtCelular);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(txtDniPaciente);
            Controls.Add(btnInsertar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxConsurDni).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtObserva;
        private PictureBox pbxConsurDni;
    }
}