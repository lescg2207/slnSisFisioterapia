namespace capaPresentacion
{
    partial class frmModalPaciente
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
            label1 = new Label();
            panel2 = new Panel();
            dgvPaciente = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 173, 138);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 51);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 10);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 0;
            label1.Text = "Lista de Pacientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPaciente);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 353);
            panel2.TabIndex = 2;
            // 
            // dgvPaciente
            // 
            dgvPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPaciente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPaciente.BackgroundColor = SystemColors.Control;
            dgvPaciente.BorderStyle = BorderStyle.None;
            dgvPaciente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPaciente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(21, 60, 77);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPaciente.ColumnHeadersHeight = 30;
            dgvPaciente.EnableHeadersVisualStyles = false;
            dgvPaciente.GridColor = SystemColors.Control;
            dgvPaciente.Location = new Point(19, 11);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.ReadOnly = true;
            dgvPaciente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPaciente.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.DimGray;
            dgvPaciente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPaciente.RowTemplate.Height = 25;
            dgvPaciente.Size = new Size(523, 325);
            dgvPaciente.TabIndex = 4;
            dgvPaciente.CellContentClick += dgvPaciente_CellContentClick;
            // 
            // frmModalPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmModalPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmModalPaciente";
            Load += frmModalPaciente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvPaciente;
    }
}