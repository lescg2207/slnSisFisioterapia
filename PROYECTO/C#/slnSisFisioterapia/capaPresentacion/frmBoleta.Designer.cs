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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 9);
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
            label5.Location = new Point(602, 57);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "FECHA:";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(88, 102);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(119, 23);
            txtdni.TabIndex = 5;
            txtdni.TextChanged += textBox1_TextChanged;
            // 
            // txtnombres
            // 
            txtnombres.Location = new Point(320, 100);
            txtnombres.Name = "txtnombres";
            txtnombres.Size = new Size(276, 23);
            txtnombres.TabIndex = 6;
            txtnombres.TextChanged += textBox2_TextChanged;
            // 
            // txtapellidos
            // 
            txtapellidos.Location = new Point(320, 141);
            txtapellidos.Name = "txtapellidos";
            txtapellidos.Size = new Size(276, 23);
            txtapellidos.TabIndex = 7;
            txtapellidos.TextChanged += textBox3_TextChanged;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(655, 54);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(129, 23);
            txtfecha.TabIndex = 8;
            txtfecha.TextChanged += textBox4_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(631, 74);
            dataGridView1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 200);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 10;
            label6.Text = "SERVICIO:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(26, 348);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(631, 125);
            dataGridView2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 325);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 12;
            label7.Text = "PRODUCTOS:";
            // 
            // button1
            // 
            button1.Location = new Point(695, 382);
            button1.Name = "button1";
            button1.Size = new Size(91, 26);
            button1.TabIndex = 13;
            button1.Text = "GENERAR";
            button1.UseVisualStyleBackColor = true;
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
            lblid.Location = new Point(40, 24);
            lblid.Name = "lblid";
            lblid.Size = new Size(18, 15);
            lblid.TabIndex = 15;
            lblid.Text = "ID";
            // 
            // frmBoleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 491);
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
    }
}