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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtdni = new TextBox();
            txtnombres = new TextBox();
            txtapellidos = new TextBox();
            txtfecha = new TextBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            dataGridView2 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 24);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 0;
            label1.Text = "GENERAR BOLETA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 103);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(232, 102);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "NOMBRES:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(227, 142);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "APELLIDOS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(596, 102);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "FECHA:";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(88, 102);
            txtdni.Name = "txtdni";
            txtdni.ReadOnly = true;
            txtdni.Size = new Size(119, 23);
            txtdni.TabIndex = 5;
            txtdni.TextChanged += textBox1_TextChanged;
            // 
            // txtnombres
            // 
            txtnombres.Location = new Point(320, 100);
            txtnombres.Name = "txtnombres";
            txtnombres.ReadOnly = true;
            txtnombres.Size = new Size(247, 23);
            txtnombres.TabIndex = 6;
            txtnombres.TextChanged += textBox2_TextChanged;
            // 
            // txtapellidos
            // 
            txtapellidos.Location = new Point(320, 141);
            txtapellidos.Name = "txtapellidos";
            txtapellidos.ReadOnly = true;
            txtapellidos.Size = new Size(247, 23);
            txtapellidos.TabIndex = 7;
            txtapellidos.TextChanged += textBox3_TextChanged;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(649, 99);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(129, 23);
            txtfecha.TabIndex = 8;
            txtfecha.TextChanged += textBox4_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(516, 74);
            dataGridView1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(51, 166);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 10;
            label6.Text = "SERVICIO:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(51, 314);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(516, 125);
            dataGridView2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(51, 291);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 12;
            label7.Text = "PRODUCTOS:";
            // 
            // button1
            // 
            button1.Location = new Point(596, 431);
            button1.Name = "button1";
            button1.Size = new Size(91, 26);
            button1.TabIndex = 13;
            button1.Text = "GENERAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(695, 431);
            button2.Name = "button2";
            button2.Size = new Size(91, 26);
            button2.TabIndex = 14;
            button2.Text = "ATRAS";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(61, 42);
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
            label8.Location = new Point(665, 361);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 16;
            label8.Text = "Total :";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(727, 366);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(28, 15);
            lbltotal.TabIndex = 17;
            lbltotal.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(638, 262);
            label11.Name = "label11";
            label11.Size = new Size(83, 21);
            label11.TabIndex = 19;
            label11.Text = "Subtotal :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(676, 293);
            label12.Name = "label12";
            label12.Size = new Size(45, 21);
            label12.TabIndex = 20;
            label12.Text = "IGV :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(624, 326);
            label13.Name = "label13";
            label13.Size = new Size(99, 21);
            label13.TabIndex = 21;
            label13.Text = "Descuento :";
            // 
            // lblTOtalCIta
            // 
            lblTOtalCIta.AutoSize = true;
            lblTOtalCIta.Location = new Point(727, 267);
            lblTOtalCIta.Name = "lblTOtalCIta";
            lblTOtalCIta.Size = new Size(28, 15);
            lblTOtalCIta.TabIndex = 22;
            lblTOtalCIta.Text = "0.00";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(727, 298);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(28, 15);
            lblImpuesto.TabIndex = 23;
            lblImpuesto.Text = "0.00";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Location = new Point(727, 331);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(28, 15);
            lbldescuento.TabIndex = 24;
            lbldescuento.Text = "0.00";
            // 
            // frmBoleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 491);
            Controls.Add(lbldescuento);
            Controls.Add(lblImpuesto);
            Controls.Add(lblTOtalCIta);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lbltotal);
            Controls.Add(label8);
            Controls.Add(lblid);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(txtfecha);
            Controls.Add(txtapellidos);
            Controls.Add(txtnombres);
            Controls.Add(txtdni);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBoleta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBoleta";
            Load += frmBoleta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private DataGridView dataGridView1;
        private Label label6;
        private DataGridView dataGridView2;
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
    }
}