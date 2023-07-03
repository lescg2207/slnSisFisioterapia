namespace capaPresentacion
{
    partial class frmEleccionBD
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
            comboBoxGestor = new ComboBox();
            ButtonConnect = new Button();
            SuspendLayout();
            // 
            // comboBoxGestor
            // 
            comboBoxGestor.FormattingEnabled = true;
            comboBoxGestor.Location = new Point(120, 41);
            comboBoxGestor.Name = "comboBoxGestor";
            comboBoxGestor.Size = new Size(121, 23);
            comboBoxGestor.TabIndex = 0;
            // 
            // ButtonConnect
            // 
            ButtonConnect.Location = new Point(202, 270);
            ButtonConnect.Name = "ButtonConnect";
            ButtonConnect.Size = new Size(75, 23);
            ButtonConnect.TabIndex = 1;
            ButtonConnect.Text = "button1";
            ButtonConnect.UseVisualStyleBackColor = true;
            ButtonConnect.Click += ButtonConnect_Click;
            // 
            // frmEleccionBD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(ButtonConnect);
            Controls.Add(comboBoxGestor);
            Name = "frmEleccionBD";
            Text = "frmEleccionBD";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxGestor;
        private Button ButtonConnect;
    }
}