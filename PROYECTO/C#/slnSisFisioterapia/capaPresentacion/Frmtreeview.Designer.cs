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
            SuspendLayout();
            // 
            // tPac
            // 
            tPac.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tPac.Location = new Point(12, 12);
            tPac.Name = "tPac";
            tPac.Size = new Size(317, 468);
            tPac.TabIndex = 0;
            tPac.AfterSelect += tPac_AfterSelect;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(371, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnactualizar
            // 
            btnactualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnactualizar.Location = new Point(747, 44);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(201, 37);
            btnactualizar.TabIndex = 5;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(371, 111);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 28);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(371, 151);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(147, 28);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(529, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(529, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 10;
            // 
            // btnagregar
            // 
            btnagregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregar.Location = new Point(571, 45);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(168, 37);
            btnagregar.TabIndex = 11;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.CornflowerBlue;
            lbl1.Location = new Point(633, 113);
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
            lbl2.ForeColor = Color.CornflowerBlue;
            lbl2.Location = new Point(633, 158);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(59, 23);
            lbl2.TabIndex = 13;
            lbl2.Text = "label2";
            lbl2.Visible = false;
            // 
            // Frmtreeview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 492);
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
    }
}