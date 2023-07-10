namespace capaPresentacion
{
    partial class FrmGestorBd
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnConectar = new Button();
            panel3 = new Panel();
            comboBoxDatabase = new ComboBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            textBoxDatabase = new TextBox();
            textBoxServer = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btncerrar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 173, 138);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 20);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Conexion";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 173, 138);
            panel2.Controls.Add(btncerrar);
            panel2.Controls.Add(btnConectar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 64);
            panel2.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.Cursor = Cursors.Hand;
            btnConectar.FlatAppearance.BorderColor = Color.White;
            btnConectar.FlatStyle = FlatStyle.Flat;
            btnConectar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConectar.ForeColor = Color.White;
            btnConectar.Location = new Point(297, 13);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(126, 35);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(21, 60, 77);
            panel3.Controls.Add(comboBoxDatabase);
            panel3.Controls.Add(textBoxPassword);
            panel3.Controls.Add(textBoxUsername);
            panel3.Controls.Add(textBoxDatabase);
            panel3.Controls.Add(textBoxServer);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 207);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // comboBoxDatabase
            // 
            comboBoxDatabase.FormattingEnabled = true;
            comboBoxDatabase.Location = new Point(175, 33);
            comboBoxDatabase.Name = "comboBoxDatabase";
            comboBoxDatabase.Size = new Size(144, 23);
            comboBoxDatabase.TabIndex = 9;
            comboBoxDatabase.SelectedIndexChanged += comboBoxDatabase_SelectedIndexChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(175, 155);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(144, 23);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(175, 125);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(144, 23);
            textBoxUsername.TabIndex = 7;
            textBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDatabase
            // 
            textBoxDatabase.Enabled = false;
            textBoxDatabase.Location = new Point(175, 95);
            textBoxDatabase.Name = "textBoxDatabase";
            textBoxDatabase.Size = new Size(144, 23);
            textBoxDatabase.TabIndex = 6;
            textBoxDatabase.Text = "bdFisioterapia";
            textBoxDatabase.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(175, 62);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(144, 23);
            textBoxServer.TabIndex = 5;
            textBoxServer.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(95, 156);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 4;
            label6.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(90, 126);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 3;
            label5.Text = "UserName :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 96);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 2;
            label4.Text = "Database :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(114, 63);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 1;
            label3.Text = "Server :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(113, 34);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 0;
            label2.Text = "Gestor :";
            // 
            // btncerrar
            // 
            btncerrar.Cursor = Cursors.Hand;
            btncerrar.FlatAppearance.BorderColor = Color.White;
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncerrar.ForeColor = Color.White;
            btncerrar.Location = new Point(25, 13);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(126, 35);
            btncerrar.TabIndex = 1;
            btncerrar.Text = "Salir";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // FrmGestorBd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 339);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestorBd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGestorBd";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox comboBoxDatabase;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxDatabase;
        private TextBox textBoxServer;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnConectar;
        private Button btncerrar;
    }
}