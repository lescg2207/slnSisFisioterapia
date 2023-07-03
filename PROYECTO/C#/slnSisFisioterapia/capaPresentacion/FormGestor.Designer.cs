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
            cbxGestor.Location = new Point(270, 120);
            cbxGestor.Name = "cbxGestor";
            cbxGestor.Size = new Size(247, 23);
            cbxGestor.TabIndex = 1;
            // 
            // FormGestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxGestor);
            Controls.Add(button1);
            Name = "FormGestor";
            Text = "FormGestor";
            Load += FormGestor_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox cbxGestor;
    }
}