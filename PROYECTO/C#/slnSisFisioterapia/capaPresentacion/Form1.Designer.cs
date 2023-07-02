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
            btnInsertar = new Button();
            txtDniPaciente = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtCelular = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnActualizar = new Button();
            dgvPaciente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(401, 193);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(135, 35);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "GUARDAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtDniPaciente
            // 
            txtDniPaciente.Location = new Point(100, 47);
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.Size = new Size(142, 23);
            txtDniPaciente.TabIndex = 2;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(100, 127);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(142, 23);
            txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(100, 205);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(142, 23);
            txtApellidos.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(100, 291);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(142, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(100, 361);
            txtCelular.MaxLength = 9;
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(142, 23);
            txtCelular.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(401, 47);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(135, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(401, 253);
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
            dgvPaciente.Location = new Point(647, 116);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.RowTemplate.Height = 25;
            dgvPaciente.Size = new Size(675, 244);
            dgvPaciente.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 450);
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
    }
}