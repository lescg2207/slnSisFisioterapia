namespace capaPresentacion
{
    partial class FrmLogin
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
            button1 = new Button();
            panel4 = new Panel();
            txtusuario = new TextBox();
            panel3 = new Panel();
            txtcontraseña = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pbclose = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbclose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 60, 77);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(109, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 454);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(543, 299);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 4;
            label1.Text = "Mensaje";
            label1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources._88;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(21, 60, 77);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 60, 77);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 60, 77);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(507, 357);
            button1.Name = "button1";
            button1.Size = new Size(347, 44);
            button1.TabIndex = 0;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources._777;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Controls.Add(txtusuario);
            panel4.Location = new Point(507, 165);
            panel4.Name = "panel4";
            panel4.Size = new Size(347, 44);
            panel4.TabIndex = 3;
            // 
            // txtusuario
            // 
            txtusuario.BorderStyle = BorderStyle.None;
            txtusuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.ForeColor = Color.DimGray;
            txtusuario.Location = new Point(60, 12);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(257, 20);
            txtusuario.TabIndex = 0;
            txtusuario.Text = "USUARIO";
            txtusuario.Enter += txtusuario_Enter_1;
            txtusuario.KeyPress += txtusuario_KeyPress;
            txtusuario.Leave += txtusuario_Leave;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources._66;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(txtcontraseña);
            panel3.Location = new Point(507, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(347, 44);
            panel3.TabIndex = 2;
            // 
            // txtcontraseña
            // 
            txtcontraseña.BorderStyle = BorderStyle.None;
            txtcontraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcontraseña.ForeColor = Color.DimGray;
            txtcontraseña.Location = new Point(60, 12);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(257, 20);
            txtcontraseña.TabIndex = 1;
            txtcontraseña.Text = "CONTRASEÑA";
            txtcontraseña.Enter += txtcontraseña_Enter;
            txtcontraseña.KeyPress += txtcontraseña_KeyPress;
            txtcontraseña.Leave += txtcontraseña_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.FDV;
            pictureBox2.Location = new Point(613, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 454);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._332;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbclose
            // 
            pbclose.Cursor = Cursors.Hand;
            pbclose.Image = Properties.Resources.cerrar;
            pbclose.Location = new Point(1066, 12);
            pbclose.Name = "pbclose";
            pbclose.Size = new Size(62, 50);
            pbclose.SizeMode = PictureBoxSizeMode.CenterImage;
            pbclose.TabIndex = 1;
            pbclose.TabStop = false;
            pbclose.Click += pbclose_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 173, 138);
            ClientSize = new Size(1140, 727);
            Controls.Add(pbclose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            MouseDown += FrmLogin_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbclose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel4;
        private Label label1;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
        private PictureBox pbclose;
    }
}