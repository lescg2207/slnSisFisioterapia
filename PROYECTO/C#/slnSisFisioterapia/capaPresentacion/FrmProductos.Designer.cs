namespace capaPresentacion
{
    partial class FrmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel1 = new Panel();
            dgvProducto = new DataGridView();
            panel3 = new Panel();
            btnlimpiar = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            lblId = new Label();
            btnregistrar = new Button();
            label10 = new Label();
            txtstock = new TextBox();
            label9 = new Label();
            txtprecio = new TextBox();
            txtNombres = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 173, 138);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnregistrar);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtstock);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtprecio);
            panel2.Controls.Add(txtNombres);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 690);
            panel2.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dgvProducto);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lblId);
            panel1.Location = new Point(328, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 699);
            panel1.TabIndex = 28;
            // 
            // dgvProducto
            // 
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducto.BackgroundColor = SystemColors.Control;
            dgvProducto.BorderStyle = BorderStyle.None;
            dgvProducto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 173, 138);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducto.ColumnHeadersHeight = 30;
            dgvProducto.EnableHeadersVisualStyles = false;
            dgvProducto.GridColor = SystemColors.Control;
            dgvProducto.Location = new Point(57, 179);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProducto.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = Color.DimGray;
            dgvProducto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvProducto.RowTemplate.Height = 25;
            dgvProducto.Size = new Size(696, 453);
            dgvProducto.TabIndex = 3;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(21, 60, 77);
            panel3.Controls.Add(btnlimpiar);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(792, 106);
            panel3.TabIndex = 0;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.FromArgb(22, 173, 138);
            btnlimpiar.FlatStyle = FlatStyle.Popup;
            btnlimpiar.Font = new Font("Arial Black", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnlimpiar.ForeColor = SystemColors.Control;
            btnlimpiar.Location = new Point(533, 40);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(220, 32);
            btnlimpiar.TabIndex = 29;
            btnlimpiar.Text = "LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(27, 46);
            label4.Name = "label4";
            label4.Size = new Size(262, 20);
            label4.TabIndex = 0;
            label4.Text = "Búsqueda por nombre de producto :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(57, 558);
            lblId.Name = "lblId";
            lblId.Size = new Size(38, 15);
            lblId.TabIndex = 2;
            lblId.Text = "label1";
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.FromArgb(21, 60, 77);
            btnregistrar.FlatStyle = FlatStyle.Popup;
            btnregistrar.Font = new Font("Arial Black", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnregistrar.ForeColor = SystemColors.Control;
            btnregistrar.Location = new Point(41, 559);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(247, 32);
            btnregistrar.TabIndex = 25;
            btnregistrar.Text = "REGISTRAR";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 62);
            label10.Name = "label10";
            label10.Size = new Size(301, 30);
            label10.TabIndex = 0;
            label10.Text = "Mantenimiento de Productos";
            // 
            // txtstock
            // 
            txtstock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtstock.Location = new Point(59, 308);
            txtstock.MaxLength = 9;
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(205, 23);
            txtstock.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(136, 288);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 24;
            label9.Text = "Stock:";
            // 
            // txtprecio
            // 
            txtprecio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtprecio.Location = new Point(59, 242);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(205, 23);
            txtprecio.TabIndex = 2;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(59, 170);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(205, 23);
            txtNombres.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(108, 222);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 18;
            label3.Text = "Precio Unitario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(121, 150);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 17;
            label2.Text = "Nombres :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(650, 638);
            button1.Name = "button1";
            button1.Size = new Size(121, 35);
            button1.TabIndex = 4;
            button1.Text = "EXPORTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 690);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductos";
            Text = "FrmProductos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtstock;
        private TextBox txtprecio;
        private TextBox txtNombres;
        private Label label9;
        private Label label2;
        private Label label3;
        private Label label10;
        private Panel panel1;
        private Button btnregistrar;
        private Panel panel3;
        private Label label4;
        private TextBox textBox1;
        private Label lblId;
        private Button btnlimpiar;
        private DataGridView dgvProducto;
        private Button button1;
    }
}