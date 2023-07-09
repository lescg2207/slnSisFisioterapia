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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnregistrar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtstock);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtprecio);
            this.panel2.Controls.Add(this.txtNombres);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 690);
            this.panel2.TabIndex = 34;
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
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.btnlimpiar);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 106);
            this.panel3.TabIndex = 0;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(138)))));
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.Font = new System.Drawing.Font("Arial Black", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlimpiar.Location = new System.Drawing.Point(533, 40);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(220, 32);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Búsqueda por nombre de producto :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 558);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(38, 15);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "label1";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.Font = new System.Drawing.Font("Arial Black", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnregistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnregistrar.Location = new System.Drawing.Point(41, 559);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(247, 32);
            this.btnregistrar.TabIndex = 25;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mantenimiento de Productos";
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtstock.Location = new System.Drawing.Point(59, 308);
            this.txtstock.MaxLength = 9;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(205, 23);
            this.txtstock.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(136, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Stock:";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtprecio.Location = new System.Drawing.Point(59, 242);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(205, 23);
            this.txtprecio.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombres.Location = new System.Drawing.Point(59, 170);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(205, 23);
            this.txtNombres.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio Unitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombres :";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 690);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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