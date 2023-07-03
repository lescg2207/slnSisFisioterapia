namespace capaPresentacion
{
    partial class FormGestor
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
            button1 = new Button();
            cbxGestor = new ComboBox();
            textBoxServer = new TextBox();
            textBoxDatabase = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(457, 305);
            button1.Name = "button1";
            button1.Size = new Size(205, 36);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbxGestor
            // 
            cbxGestor.FormattingEnabled = true;
            cbxGestor.Location = new Point(360, 56);
            cbxGestor.Name = "cbxGestor";
            cbxGestor.Size = new Size(247, 23);
            cbxGestor.TabIndex = 1;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(394, 112);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(213, 23);
            textBoxServer.TabIndex = 2;
            // 
            // textBoxDatabase
            // 
            textBoxDatabase.Location = new Point(394, 153);
            textBoxDatabase.Name = "textBoxDatabase";
            textBoxDatabase.Size = new Size(213, 23);
            textBoxDatabase.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(394, 193);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(213, 23);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(394, 232);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(213, 23);
            textBoxPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 115);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 156);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Database";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 196);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 8;
            label3.Text = "User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 235);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // FormGestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxDatabase);
            Controls.Add(textBoxServer);
            Controls.Add(cbxGestor);
            Controls.Add(button1);
            Name = "FormGestor";
            Text = "FormGestor";
            Load += FormGestor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cbxGestor;
        private TextBox textBoxServer;
        private TextBox textBoxDatabase;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}