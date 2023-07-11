namespace capaPresentacion
{
    partial class frmBoleta
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtdni = new TextBox();
            txtnombres = new TextBox();
            txtapellidos = new TextBox();
            txtfecha = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            lblid = new Label();
            label8 = new Label();
            lbltotal = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblTOtalCIta = new Label();
            lblImpuesto = new Label();
            lbldescuento = new Label();
            dgvProductos = new DataGridView();
            dgvServicio = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(265, 18);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 0;
            label1.Text = "GENERAR BOLETA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 135);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(229, 134);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "NOMBRES:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(224, 174);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "APELLIDOS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(593, 134);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "FECHA:";
            // 
            // txtdni
            // 
            txtdni.BackColor = Color.White;
            txtdni.Location = new Point(85, 134);
            txtdni.Name = "txtdni";
            txtdni.ReadOnly = true;
            txtdni.Size = new Size(119, 23);
            txtdni.TabIndex = 5;
            txtdni.TextChanged += textBox1_TextChanged;
            // 
            // txtnombres
            // 
            txtnombres.BackColor = Color.White;
            txtnombres.Location = new Point(317, 132);
            txtnombres.Name = "txtnombres";
            txtnombres.ReadOnly = true;
            txtnombres.Size = new Size(247, 23);
            txtnombres.TabIndex = 6;
            txtnombres.TextChanged += textBox2_TextChanged;
            // 
            // txtapellidos
            // 
            txtapellidos.BackColor = Color.White;
            txtapellidos.Location = new Point(317, 173);
            txtapellidos.Name = "txtapellidos";
            txtapellidos.ReadOnly = true;
            txtapellidos.Size = new Size(247, 23);
            txtapellidos.TabIndex = 7;
            txtapellidos.TextChanged += textBox3_TextChanged;
            // 
            // txtfecha
            // 
            txtfecha.BackColor = Color.White;
            txtfecha.Location = new Point(659, 131);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(124, 23);
            txtfecha.TabIndex = 8;
            txtfecha.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(48, 198);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 10;
            label6.Text = "SERVICIO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(48, 323);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 12;
            label7.Text = "PRODUCTOS:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(576, 463);
            button1.Name = "button1";
            button1.Size = new Size(91, 30);
            button1.TabIndex = 13;
            button1.Text = "GENERAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(673, 463);
            button2.Name = "button2";
            button2.Size = new Size(91, 30);
            button2.TabIndex = 14;
            button2.Text = "ATRAS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(757, 40);
            lblid.Name = "lblid";
            lblid.Size = new Size(13, 15);
            lblid.TabIndex = 15;
            lblid.Text = "2";
            lblid.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(662, 393);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 16;
            label8.Text = "Total :";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(724, 398);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(28, 15);
            lbltotal.TabIndex = 17;
            lbltotal.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(635, 294);
            label11.Name = "label11";
            label11.Size = new Size(83, 21);
            label11.TabIndex = 19;
            label11.Text = "Subtotal :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(673, 325);
            label12.Name = "label12";
            label12.Size = new Size(45, 21);
            label12.TabIndex = 20;
            label12.Text = "IGV :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(621, 358);
            label13.Name = "label13";
            label13.Size = new Size(99, 21);
            label13.TabIndex = 21;
            label13.Text = "Descuento :";
            // 
            // lblTOtalCIta
            // 
            lblTOtalCIta.AutoSize = true;
            lblTOtalCIta.Location = new Point(724, 299);
            lblTOtalCIta.Name = "lblTOtalCIta";
            lblTOtalCIta.Size = new Size(28, 15);
            lblTOtalCIta.TabIndex = 22;
            lblTOtalCIta.Text = "0.00";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(724, 330);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(28, 15);
            lblImpuesto.TabIndex = 23;
            lblImpuesto.Text = "0.00";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Location = new Point(724, 363);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(28, 15);
            lbldescuento.TabIndex = 24;
            lbldescuento.Text = "0.00";
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 173, 138);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = SystemColors.Control;
            dgvProductos.Location = new Point(48, 358);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.DimGray;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(516, 131);
            dgvProductos.TabIndex = 25;
            // 
            // dgvServicio
            // 
            dgvServicio.BackgroundColor = Color.White;
            dgvServicio.BorderStyle = BorderStyle.None;
            dgvServicio.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServicio.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 173, 138);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvServicio.ColumnHeadersHeight = 30;
            dgvServicio.EnableHeadersVisualStyles = false;
            dgvServicio.GridColor = SystemColors.Control;
            dgvServicio.Location = new Point(48, 237);
            dgvServicio.Name = "dgvServicio";
            dgvServicio.ReadOnly = true;
            dgvServicio.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvServicio.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvServicio.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = Color.DimGray;
            dgvServicio.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvServicio.RowTemplate.Height = 25;
            dgvServicio.Size = new Size(516, 77);
            dgvServicio.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 173, 138);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblid);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 76);
            panel1.TabIndex = 27;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // frmBoleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 533);
            Controls.Add(panel1);
            Controls.Add(dgvServicio);
            Controls.Add(dgvProductos);
            Controls.Add(lbldescuento);
            Controls.Add(lblImpuesto);
            Controls.Add(lblTOtalCIta);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lbltotal);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtfecha);
            Controls.Add(txtapellidos);
            Controls.Add(txtnombres);
            Controls.Add(txtdni);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBoleta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBoleta";
            Load += frmBoleta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtdni;
        private TextBox txtapellidos;
        private TextBox txtfecha;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        public Label lblid;
        public TextBox txtnombres;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        public Label lblTOtalCIta;
        public Label lblImpuesto;
        public Label lbldescuento;
        public Label lbltotal;
        private DataGridView dgvProductos;
        private DataGridView dgvServicio;
        private Panel panel1;
    }
}