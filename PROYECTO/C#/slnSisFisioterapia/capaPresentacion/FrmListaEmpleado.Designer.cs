namespace capaPresentacion
{
    partial class FrmListaEmpleado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            lbltitu = new Label();
            dgvEmpleado = new DataGridView();
            lblId = new Label();
            lblcontra = new Label();
            btnLimpiar = new Button();
            panel3 = new Panel();
            cbxCargo = new ComboBox();
            txtxContraseña = new TextBox();
            txtusuarios = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            btnAgregar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtbuscar = new TextBox();
            cbxBuscar = new ComboBox();
            label1 = new Label();
            btnExportar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 173, 138);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 63);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 15);
            label2.Name = "label2";
            label2.Size = new Size(307, 30);
            label2.TabIndex = 0;
            label2.Text = "Mantenimiento de Empleados";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbltitu);
            panel2.Controls.Add(dgvEmpleado);
            panel2.Controls.Add(lblId);
            panel2.Controls.Add(lblcontra);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtbuscar);
            panel2.Controls.Add(cbxBuscar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnExportar);
            panel2.Location = new Point(12, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 597);
            panel2.TabIndex = 2;
            // 
            // lbltitu
            // 
            lbltitu.AutoSize = true;
            lbltitu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitu.Location = new Point(322, 167);
            lbltitu.Name = "lbltitu";
            lbltitu.Size = new Size(113, 17);
            lbltitu.TabIndex = 12;
            lbltitu.Text = "Ingrese nombre :";
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.BackgroundColor = SystemColors.Control;
            dgvEmpleado.BorderStyle = BorderStyle.None;
            dgvEmpleado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmpleado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 173, 138);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleado.ColumnHeadersHeight = 30;
            dgvEmpleado.EnableHeadersVisualStyles = false;
            dgvEmpleado.GridColor = SystemColors.Control;
            dgvEmpleado.Location = new Point(35, 259);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.ReadOnly = true;
            dgvEmpleado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleado.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.DimGray;
            dgvEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleado.RowTemplate.Height = 25;
            dgvEmpleado.Size = new Size(1020, 265);
            dgvEmpleado.TabIndex = 0;
            dgvEmpleado.CellContentClick += dgvEmpleado_CellContentClick;
            dgvEmpleado.CellPainting += dgvEmpleado_CellPainting;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(963, 270);
            lblId.Name = "lblId";
            lblId.Size = new Size(38, 15);
            lblId.TabIndex = 11;
            lblId.Text = "label8";
            // 
            // lblcontra
            // 
            lblcontra.AutoSize = true;
            lblcontra.Location = new Point(1017, 270);
            lblcontra.Name = "lblcontra";
            lblcontra.Size = new Size(38, 15);
            lblcontra.TabIndex = 10;
            lblcontra.Text = "label8";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(907, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(148, 30);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbxCargo);
            panel3.Controls.Add(txtxContraseña);
            panel3.Controls.Add(txtusuarios);
            panel3.Controls.Add(txtApellidos);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1096, 137);
            panel3.TabIndex = 6;
            // 
            // cbxCargo
            // 
            cbxCargo.FormattingEnabled = true;
            cbxCargo.Items.AddRange(new object[] { "Seleccione" });
            cbxCargo.Location = new Point(854, 25);
            cbxCargo.Name = "cbxCargo";
            cbxCargo.Size = new Size(201, 23);
            cbxCargo.TabIndex = 9;
            // 
            // txtxContraseña
            // 
            txtxContraseña.Location = new Point(494, 66);
            txtxContraseña.Name = "txtxContraseña";
            txtxContraseña.PasswordChar = '*';
            txtxContraseña.Size = new Size(215, 23);
            txtxContraseña.TabIndex = 8;
            txtxContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // txtusuarios
            // 
            txtusuarios.Location = new Point(494, 27);
            txtusuarios.Name = "txtusuarios";
            txtusuarios.Size = new Size(215, 23);
            txtusuarios.TabIndex = 7;
            txtusuarios.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(115, 66);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(215, 23);
            txtApellidos.TabIndex = 6;
            txtApellidos.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 5;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(796, 26);
            label7.Name = "label7";
            label7.Size = new Size(52, 17);
            label7.TabIndex = 4;
            label7.Text = "Cargo :";
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(907, 67);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(148, 30);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(403, 67);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 3;
            label6.Text = "Contraseña :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(425, 28);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 2;
            label5.Text = "Usuario :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 67);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 1;
            label4.Text = "Apellidos :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 29);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 0;
            label3.Text = "Nombres :";
            // 
            // txtbuscar
            // 
            txtbuscar.ForeColor = Color.DimGray;
            txtbuscar.Location = new Point(322, 187);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(207, 23);
            txtbuscar.TabIndex = 5;
            txtbuscar.TextAlign = HorizontalAlignment.Center;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // cbxBuscar
            // 
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Items.AddRange(new object[] { "NOMBRE", "CARGO" });
            cbxBuscar.Location = new Point(143, 187);
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(173, 23);
            cbxBuscar.TabIndex = 4;
            cbxBuscar.SelectedIndexChanged += cbxBuscar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 188);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 3;
            label1.Text = "Búsqueda por :";
            // 
            // btnExportar
            // 
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Location = new Point(907, 546);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(148, 30);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FrmListaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 690);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaEmpleado";
            Text = "FrmListaUsusario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvEmpleado;
        private Button btnAgregar;
        private Button btnExportar;
        private TextBox txtbuscar;
        private ComboBox cbxBuscar;
        private Label label1;
        private Button btnLimpiar;
        private Panel panel3;
        private ComboBox cbxCargo;
        private TextBox txtxContraseña;
        private TextBox txtusuarios;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblcontra;
        private Label lblId;
        private Label lbltitu;
    }
}