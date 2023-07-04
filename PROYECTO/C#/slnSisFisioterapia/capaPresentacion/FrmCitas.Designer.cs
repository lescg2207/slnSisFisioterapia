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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            btnBuscar = new Button();
            txtDniPaciente = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cbxHorario = new ComboBox();
            cbxDoctor = new ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 41);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Dni :";
            // 
            // lblIdEmp
            // 
            lblIdEmp.AutoSize = true;
            lblIdEmp.Location = new Point(71, 119);
            lblIdEmp.Name = "lblIdEmp";
            lblIdEmp.Size = new Size(49, 15);
            lblIdEmp.TabIndex = 1;
            lblIdEmp.Text = "Doctor :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 57);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 96);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Hora :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(515, 37);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "estadodePago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 37);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 37);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 6;
            label7.Text = "estadoCita";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 173, 138);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 616);
            panel1.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(227, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDniPaciente
            // 
            txtDniPaciente.Location = new Point(71, 60);
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.Size = new Size(150, 23);
            txtDniPaciente.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(477, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // cbxHorario
            // 
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(477, 93);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(136, 23);
            cbxHorario.TabIndex = 0;
            // 
            // cbxDoctor
            // 
            cbxDoctor.FormattingEnabled = true;
            cbxDoctor.Location = new Point(71, 137);
            cbxDoctor.Name = "cbxDoctor";
            cbxDoctor.Size = new Size(147, 23);
            cbxDoctor.TabIndex = 7;
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
            panel2.Controls.Add(dateTimePicker1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 200);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(1096, 84);
            panel3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 403);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(605, 193);
            dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(582, 360);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(501, 360);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(420, 361);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(339, 360);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 361);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 15;
            textBox1.Text = "Ingresa nombre del doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 364);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 16;
            label2.Text = "Buscar :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(21, 60, 77);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(1096, 44);
            panel4.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(52, 311);
            label8.Name = "label8";
            label8.Size = new Size(156, 21);
            label8.TabIndex = 17;
            label8.Text = "Lista de cita del dia";
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 690);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCitas";
            Text = "FrmCitas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblIdEmp;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbxHorario;
        private Button btnBuscar;
        private TextBox txtDniPaciente;
        private Panel panel2;
        private ComboBox cbxDoctor;
        private Label label2;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel4;
        private Label label8;
    }
}