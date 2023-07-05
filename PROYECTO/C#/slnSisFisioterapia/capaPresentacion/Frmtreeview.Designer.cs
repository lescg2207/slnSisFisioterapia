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
            SuspendLayout();
            // 
            // tPac
            // 
            tPac.Location = new Point(12, 12);
            tPac.Name = "tPac";
            tPac.Size = new Size(317, 468);
            tPac.TabIndex = 0;
            // 
            // Frmtreeview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(tPac);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmtreeview";
            Text = "Frmtreeview";
            ResumeLayout(false);
        }

        #endregion

        private TreeView tPac;
    }
}