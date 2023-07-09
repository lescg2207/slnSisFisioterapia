namespace capaPresentacion
{
    partial class FrmDetalleCita
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblservicios = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncitas = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecServ = new System.Windows.Forms.TextBox();
            this.txtservicios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnservicios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprec = new System.Windows.Forms.TextBox();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnproducto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDcita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidProd = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.panel4.Controls.Add(this.lbltitulo);
            this.panel4.Controls.Add(this.lblservicios);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(683, 60);
            this.panel4.TabIndex = 9;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(25, 14);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(164, 30);
            this.lbltitulo.TabIndex = 10;
            this.lbltitulo.Text = "Detalle de Citas";
            // 
            // lblservicios
            // 
            this.lblservicios.AutoSize = true;
            this.lblservicios.Location = new System.Drawing.Point(624, 11);
            this.lblservicios.Name = "lblservicios";
            this.lblservicios.Size = new System.Drawing.Size(10, 15);
            this.lblservicios.TabIndex = 38;
            this.lblservicios.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Controls.Add(this.btncitas);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnservicios);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnproducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblsubtotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDcita);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 504);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(175, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 23);
            this.button5.TabIndex = 37;
            this.button5.Text = "LIMPIAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(25, 442);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(144, 23);
            this.btnregistrar.TabIndex = 36;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // btncitas
            // 
            this.btncitas.Location = new System.Drawing.Point(382, 38);
            this.btncitas.Name = "btncitas";
            this.btncitas.Size = new System.Drawing.Size(53, 23);
            this.btncitas.TabIndex = 35;
            this.btncitas.Text = "...";
            this.btncitas.UseVisualStyleBackColor = true;
            this.btncitas.Click += new System.EventHandler(this.btncitas_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(496, 439);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 23);
            this.comboBox1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtprecServ);
            this.panel2.Controls.Add(this.txtservicios);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(25, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 86);
            this.panel2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Precio:";
            // 
            // txtprecServ
            // 
            this.txtprecServ.Location = new System.Drawing.Point(406, 35);
            this.txtprecServ.Name = "txtprecServ";
            this.txtprecServ.Size = new System.Drawing.Size(158, 23);
            this.txtprecServ.TabIndex = 1;
            this.txtprecServ.TextChanged += new System.EventHandler(this.txtprecServ_TextChanged);
            // 
            // txtservicios
            // 
            this.txtservicios.Location = new System.Drawing.Point(107, 35);
            this.txtservicios.Name = "txtservicios";
            this.txtservicios.Size = new System.Drawing.Size(161, 23);
            this.txtservicios.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Servicio:";
            // 
            // btnservicios
            // 
            this.btnservicios.Location = new System.Drawing.Point(153, 96);
            this.btnservicios.Name = "btnservicios";
            this.btnservicios.Size = new System.Drawing.Size(122, 23);
            this.btnservicios.TabIndex = 30;
            this.btnservicios.Text = "Añadir Servicios";
            this.btnservicios.UseVisualStyleBackColor = true;
            this.btnservicios.Click += new System.EventHandler(this.btnservicios_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.txtprec);
            this.panel1.Controls.Add(this.txtprod);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(25, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 86);
            this.panel1.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(502, 34);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(109, 23);
            this.txtcantidad.TabIndex = 24;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            // 
            // txtprec
            // 
            this.txtprec.Location = new System.Drawing.Point(342, 34);
            this.txtprec.Name = "txtprec";
            this.txtprec.Size = new System.Drawing.Size(122, 23);
            this.txtprec.TabIndex = 1;
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(88, 34);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(122, 23);
            this.txtprod.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Precio Unitario:";
            // 
            // btnproducto
            // 
            this.btnproducto.Location = new System.Drawing.Point(25, 96);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(122, 23);
            this.btnproducto.TabIndex = 28;
            this.btnproducto.Text = "Añadir Producto";
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Impuesto:";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(614, 366);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(22, 15);
            this.lblsubtotal.TabIndex = 25;
            this.lblsubtotal.Text = "0.0";
            this.lblsubtotal.TextChanged += new System.EventHandler(this.lblsubtotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Subtotal:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(537, 39);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(119, 23);
            this.txtDNI.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(463, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Paciente :";
            // 
            // txtIDcita
            // 
            this.txtIDcita.Location = new System.Drawing.Point(119, 38);
            this.txtIDcita.Name = "txtIDcita";
            this.txtIDcita.Size = new System.Drawing.Size(245, 23);
            this.txtIDcita.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo Cita :";
            // 
            // txtidProd
            // 
            this.txtidProd.AutoSize = true;
            this.txtidProd.Location = new System.Drawing.Point(636, 38);
            this.txtidProd.Name = "txtidProd";
            this.txtidProd.Size = new System.Drawing.Size(38, 15);
            this.txtidProd.TabIndex = 38;
            this.txtidProd.Text = "label7";
            this.txtidProd.Click += new System.EventHandler(this.txtidProd_Click);
            // 
            // FrmDetalleCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(707, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtidProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalleCita";
            this.Text = "FrmDetalleCita";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel4;
        private Label lbltitulo;
        private GroupBox groupBox1;
        private Label label8;
        private Label lblsubtotal;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDNI;
        private Label label2;
        private TextBox txtIDcita;
        private Label label1;
        private Panel panel1;
        private TextBox txtprec;
        private TextBox txtprod;
        private Button btnproducto;
        private Button btncitas;
        private ComboBox comboBox1;
        private Panel panel2;
        private Label label9;
        private TextBox txtprecServ;
        private TextBox txtservicios;
        private Button btnservicios;
        private Label label10;
        private TextBox txtcantidad;
        private Button button5;
        private Button btnregistrar;
        private Label txtidProd;
        private Label lblservicios;
    }
}