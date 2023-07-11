namespace capaPresentacion
{
    partial class Frmtreeview
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
            components = new System.ComponentModel.Container();
            tPac = new TreeView();
            comboBox1 = new ComboBox();
            btnactualizar = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnagregar = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnNuevo = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tPac
            // 
            tPac.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tPac.Location = new Point(12, 111);
            tPac.Name = "tPac";
            tPac.Size = new Size(317, 462);
            tPac.TabIndex = 0;
            tPac.AfterSelect += tPac_AfterSelect;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(351, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 33);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.White;
            btnactualizar.FlatAppearance.BorderColor = Color.Black;
            btnactualizar.FlatStyle = FlatStyle.Flat;
            btnactualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnactualizar.Location = new Point(873, 149);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(201, 37);
            btnactualizar.TabIndex = 5;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(351, 226);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 33);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(351, 266);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(147, 33);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(510, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(510, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 33);
            textBox2.TabIndex = 10;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.White;
            btnagregar.FlatAppearance.BorderColor = Color.Black;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregar.Location = new Point(873, 97);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(201, 37);
            btnagregar.TabIndex = 11;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.RoyalBlue;
            lbl1.Location = new Point(614, 228);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(59, 23);
            lbl1.TabIndex = 12;
            lbl1.Text = "label1";
            lbl1.Visible = false;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.RoyalBlue;
            lbl2.Location = new Point(614, 273);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(59, 23);
            lbl2.TabIndex = 13;
            lbl2.Text = "label2";
            lbl2.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 173, 138);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 63);
            panel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(223, 30);
            label2.TabIndex = 0;
            label2.Text = "Configuracion Global";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 599);
            label1.Name = "label1";
            label1.Size = new Size(100, 40);
            label1.TabIndex = 15;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.White;
            btnNuevo.FlatAppearance.BorderColor = Color.Black;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(873, 335);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(201, 37);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Limpiar";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // Frmtreeview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 668);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnagregar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(btnactualizar);
            Controls.Add(comboBox1);
            Controls.Add(tPac);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmtreeview";
            Text = "Frmtreeview";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tPac;
        private ComboBox comboBox1;
        private Button btnactualizar;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnagregar;
        private Label lbl1;
        private Label lbl2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btnNuevo;
    }
}