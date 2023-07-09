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
            cbxDoctor = new ComboBox();
            cbxHorario = new ComboBox();
            dtpfecha = new DateTimePicker();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            btnBuscar = new Button();
            lblDniPac = new Label();
            lblNombre = new Label();
            label5 = new Label();
            btnSalir = new Button();
            btnGuardar = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdEmp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
  
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
           
            this.label2 = new System.Windows.Forms.Label();
          
            this.btnGuardar = new System.Windows.Forms.Button();
         
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 17);
            label1.TabIndex = 0;
            label1.Text = "Dni :";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dni :";
            // 
            // lblIdEmp
            // 
            lblIdEmp.AutoSize = true;
            lblIdEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdEmp.Location = new Point(27, 98);
            lblIdEmp.Name = "lblIdEmp";
            lblIdEmp.Size = new Size(58, 17);
            lblIdEmp.TabIndex = 1;
            lblIdEmp.Text = "Doctor :";
            this.lblIdEmp.AutoSize = true;
            this.lblIdEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdEmp.Location = new System.Drawing.Point(55, 109);
            this.lblIdEmp.Name = "lblIdEmp";
            this.lblIdEmp.Size = new System.Drawing.Size(58, 17);
            this.lblIdEmp.TabIndex = 1;
            this.lblIdEmp.Text = "Doctor :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(212, 98);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 2;
            label3.Text = "Fecha :";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(404, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 161);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 3;
            label4.Text = "Hora :";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(409, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora :";
            // 
            // lblEstadopago
            // 
           
            // 
            // cbxDoctor
            // 
            cbxDoctor.FormattingEnabled = true;
            cbxDoctor.Location = new Point(32, 118);
            cbxDoctor.Name = "cbxDoctor";
            cbxDoctor.Size = new Size(147, 23);
            cbxDoctor.TabIndex = 7;
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Location = new System.Drawing.Point(55, 127);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(147, 23);
            this.cbxDoctor.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(226, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtDniPaciente
            // 
            
            // 
            // cbxHorario
            // 
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(32, 181);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(147, 23);
            cbxHorario.TabIndex = 0;
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(461, 97);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(136, 23);
            this.cbxHorario.TabIndex = 0;
            // 
            // dtpfecha
            // 
            dtpfecha.CustomFormat = "dd/MM/yyyy";
            dtpfecha.Format = DateTimePickerFormat.Short;
            dtpfecha.Location = new Point(225, 118);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(177, 23);
            dtpfecha.TabIndex = 4;
            this.dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(461, 55);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(136, 23);
            this.dtpfecha.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(21, 60, 77);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 55);
            panel4.TabIndex = 8;
            
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1096, 44);
            this.panel4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 11);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 0;
            label2.Text = "Nueva Cita";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(lblDniPac);
            panel5.Controls.Add(lblNombre);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(btnSalir);
            panel5.Controls.Add(btnGuardar);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(cbxDoctor);
            panel5.Controls.Add(dtpfecha);
            panel5.Controls.Add(cbxHorario);
            panel5.Controls.Add(lblIdEmp);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(12, 73);
            panel5.Name = "panel5";
            panel5.Size = new Size(450, 250);
            panel5.TabIndex = 9;
            
            this.panel5.Location = new System.Drawing.Point(12, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1096, 616);
            this.panel5.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(327, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblDniPac
            // 
            lblDniPac.AutoSize = true;
            lblDniPac.Location = new Point(225, 60);
            lblDniPac.Name = "lblDniPac";
            lblDniPac.Size = new Size(55, 15);
            lblDniPac.TabIndex = 23;
            lblDniPac.Text = "71125560";
            
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 15);
            lblNombre.TabIndex = 22;
            lblNombre.Text = "Leslie Cardoza";
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 33);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 21;
            label5.Text = "Paciente :";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Buscar :";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(327, 179);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "ATRAS";
            btnSalir.UseVisualStyleBackColor = true;
            
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(225, 179);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            this.btnGuardar.Location = new System.Drawing.Point(380, 356);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 335);
            Controls.Add(panel5);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCitas";
            
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCitas";
            this.Text = "FrmCitas";
           

        }

        #endregion

        private Label label1;
        private Label lblIdEmp;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpfecha;
        private ComboBox cbxHorario;
        private ComboBox cbxDoctor;
        private Panel panel4;
        private Panel panel5;
        private Button btnGuardar;
        private Label label2;
        private Label lblDniPac;
        private Label label5;
        private Button btnSalir;
        private Button btnBuscar;
        public Label lblNombre;
    }
}