namespace capaPresentacion
{
    partial class FrmCitas
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
            label1 = new Label();
            lblIdEmp = new Label();
            label3 = new Label();
            label4 = new Label();
            lblEstadopago = new Label();
            lblTotal = new Label();
            lblEstadoCita = new Label();
            dgvCitas = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            cbxDoctor = new ComboBox();
            btnBuscar = new Button();
            txtDniPaciente = new TextBox();
            cbxHorario = new ComboBox();
            dtpfecha = new DateTimePicker();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnGuardar = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panelIzquierda = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 45);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 0;
            label1.Text = "Dni :";
            // 
            // lblIdEmp
            // 
            lblIdEmp.AutoSize = true;
            lblIdEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdEmp.Location = new Point(55, 109);
            lblIdEmp.Name = "lblIdEmp";
            lblIdEmp.Size = new Size(58, 17);
            lblIdEmp.TabIndex = 1;
            lblIdEmp.Text = "Doctor :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(404, 59);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 2;
            label3.Text = "Fecha :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(409, 98);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 3;
            label4.Text = "Hora :";
            // 
            // lblEstadopago
            // 
            lblEstadopago.AutoSize = true;
            lblEstadopago.Location = new Point(526, 37);
            lblEstadopago.Name = "lblEstadopago";
            lblEstadopago.Size = new Size(13, 15);
            lblEstadopago.TabIndex = 4;
            lblEstadopago.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(55, 37);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(28, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0.00";
            // 
            // lblEstadoCita
            // 
            lblEstadoCita.AutoSize = true;
            lblEstadoCita.Location = new Point(273, 37);
            lblEstadoCita.Name = "lblEstadoCita";
            lblEstadoCita.Size = new Size(13, 15);
            lblEstadoCita.TabIndex = 6;
            lblEstadoCita.Text = "1";
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(25, 403);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowTemplate.Height = 25;
            dgvCitas.Size = new Size(605, 193);
            dgvCitas.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblEstadopago);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(lblEstadoCita);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(670, 84);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxDoctor);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtDniPaciente);
            panel2.Controls.Add(lblIdEmp);
            panel2.Controls.Add(cbxHorario);
            panel2.Controls.Add(dtpfecha);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 200);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // cbxDoctor
            // 
            cbxDoctor.FormattingEnabled = true;
            cbxDoctor.Location = new Point(55, 127);
            cbxDoctor.Name = "cbxDoctor";
            cbxDoctor.Size = new Size(147, 23);
            cbxDoctor.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(211, 63);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDniPaciente
            // 
            txtDniPaciente.Location = new Point(55, 64);
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.Size = new Size(150, 23);
            txtDniPaciente.TabIndex = 5;
            // 
            // cbxHorario
            // 
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(461, 97);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(136, 23);
            cbxHorario.TabIndex = 0;
            // 
            // dtpfecha
            // 
            dtpfecha.CustomFormat = "dd/MM/yyyy";
            dtpfecha.Format = DateTimePickerFormat.Short;
            dtpfecha.Location = new Point(461, 55);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(136, 23);
            dtpfecha.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(21, 60, 77);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(1096, 44);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panelIzquierda);
            panel5.Location = new Point(12, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(1096, 616);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(22, 173, 138);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(txtBuscar);
            panel6.Controls.Add(btnGuardar);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(dgvCitas);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(213, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(670, 616);
            panel6.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(33, 306);
            label8.Name = "label8";
            label8.Size = new Size(156, 21);
            label8.TabIndex = 24;
            label8.Text = "Lista de cita del dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 359);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 23;
            label2.Text = "Buscar :";
            // 
            // txtBuscar
            // 
            txtBuscar.ForeColor = Color.DimGray;
            txtBuscar.Location = new Point(87, 356);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(165, 23);
            txtBuscar.TabIndex = 22;
            txtBuscar.Text = "Ingresa nombre del doctor";
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(380, 356);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(555, 355);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(461, 355);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 19;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(883, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 616);
            panel1.TabIndex = 10;
            // 
            // panelIzquierda
            // 
            panelIzquierda.Dock = DockStyle.Left;
            panelIzquierda.Location = new Point(0, 0);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(213, 616);
            panelIzquierda.TabIndex = 8;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 690);
            Controls.Add(panel5);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCitas";
            Text = "FrmCitas";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblIdEmp;
        private Label label3;
        private Label label4;
        private Label lblEstadopago;
        private Label lblTotal;
        private Label lblEstadoCita;
        private DateTimePicker dtpfecha;
        private ComboBox cbxHorario;
        private Button btnBuscar;
        private TextBox txtDniPaciente;
        private Panel panel2;
        private ComboBox cbxDoctor;
        private DataGridView dgvCitas;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panelIzquierda;
        private Panel panel6;
        private Panel panel1;
        private Label label8;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnGuardar;
        private Button button1;
        private Button button2;
    }
}