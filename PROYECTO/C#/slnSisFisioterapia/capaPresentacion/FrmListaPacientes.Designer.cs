namespace capaPresentacion
{
    partial class FrmListaPacientes
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
            textBox1 = new TextBox();
            cbxBuscar = new ComboBox();
            label1 = new Label();
            btnNuevo = new Button();
            btnExportar = new Button();
            dgvPacientes = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 173, 138);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 63);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(185, 30);
            label2.TabIndex = 0;
            label2.Text = "Lista de Pacientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(cbxBuscar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(btnExportar);
            panel2.Location = new Point(12, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 597);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(839, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cbxBuscar
            // 
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Location = new Point(703, 50);
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(130, 23);
            cbxBuscar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(583, 50);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 3;
            label1.Text = "Búsqueda por :";
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(38, 44);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(118, 30);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnExportar
            // 
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Location = new Point(972, 528);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(118, 30);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = SystemColors.Control;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPacientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 173, 138);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.ColumnHeadersHeight = 30;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.GridColor = SystemColors.Control;
            dgvPacientes.Location = new Point(50, 213);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.DimGray;
            dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.RowTemplate.Height = 25;
            dgvPacientes.Size = new Size(1020, 373);
            dgvPacientes.TabIndex = 2;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            // 
            // FrmListaPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 690);
            Controls.Add(dgvPacientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaPacientes";
            Text = "FrmListaPacientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private ComboBox cbxBuscar;
        private Label label1;
        private Button btnNuevo;
        private Button btnExportar;
        private Label label2;
        private DataGridView dgvPacientes;
    }
}