﻿namespace capaPresentacion
{
    partial class FrmDetalleDeCita
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            lbltotalCita = new Label();
            label7 = new Label();
            pServicios = new Panel();
            btnGuardar = new Button();
            label5 = new Label();
            txtPrecio = new TextBox();
            tServicio = new TreeView();
            panel5 = new Panel();
            label3 = new Label();
            ckbServicio = new CheckBox();
            pProductos = new Panel();
            label4 = new Label();
            btnAgregar = new Button();
            label9 = new Label();
            comboBoxProductos = new ComboBox();
            label6 = new Label();
            txtCantidad = new TextBox();
            lbltotal = new Label();
            dgvListaProductos = new DataGridView();
            panel4 = new Panel();
            label2 = new Label();
            ckbPruductos = new CheckBox();
            panel3 = new Panel();
            lblIdCita = new Label();
            label1 = new Label();
            ckbEstadoCita = new CheckBox();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            pServicios.SuspendLayout();
            panel5.SuspendLayout();
            pProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 46);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(pServicios);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(pProductos);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 745);
            panel2.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnGuardar);
            panel7.Controls.Add(lbltotalCita);
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 678);
            panel7.Name = "panel7";
            panel7.Size = new Size(647, 49);
            panel7.TabIndex = 14;
            // 
            // lbltotalCita
            // 
            lbltotalCita.AutoSize = true;
            lbltotalCita.Location = new Point(579, 19);
            lbltotalCita.Name = "lbltotalCita";
            lbltotalCita.Size = new Size(13, 15);
            lbltotalCita.TabIndex = 12;
            lbltotalCita.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(526, 17);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 5;
            label7.Text = "Total :";
            // 
            // pServicios
            // 
            pServicios.Controls.Add(label5);
            pServicios.Controls.Add(txtPrecio);
            pServicios.Controls.Add(tServicio);
            pServicios.Dock = DockStyle.Top;
            pServicios.Location = new Point(0, 438);
            pServicios.Name = "pServicios";
            pServicios.Size = new Size(647, 240);
            pServicios.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(38, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(377, 97);
            label5.Name = "label5";
            label5.Size = new Size(100, 17);
            label5.TabIndex = 15;
            label5.Text = "Total Servicio :";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(377, 131);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 1;
            // 
            // tServicio
            // 
            tServicio.Location = new Point(41, 6);
            tServicio.Name = "tServicio";
            tServicio.Size = new Size(265, 228);
            tServicio.TabIndex = 0;
            tServicio.AfterSelect += tServicio_AfterSelect;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(ckbServicio);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 381);
            panel5.Name = "panel5";
            panel5.Size = new Size(647, 57);
            panel5.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 22);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 6;
            label3.Text = "Agregar Servicio";
            // 
            // ckbServicio
            // 
            ckbServicio.AutoSize = true;
            ckbServicio.Location = new Point(41, 25);
            ckbServicio.Name = "ckbServicio";
            ckbServicio.Size = new Size(15, 14);
            ckbServicio.TabIndex = 5;
            ckbServicio.UseVisualStyleBackColor = true;
            ckbServicio.CheckedChanged += ckbServicio_CheckedChanged;
            // 
            // pProductos
            // 
            pProductos.BackColor = SystemColors.ActiveBorder;
            pProductos.Controls.Add(label4);
            pProductos.Controls.Add(btnAgregar);
            pProductos.Controls.Add(label9);
            pProductos.Controls.Add(comboBoxProductos);
            pProductos.Controls.Add(label6);
            pProductos.Controls.Add(txtCantidad);
            pProductos.Controls.Add(lbltotal);
            pProductos.Controls.Add(dgvListaProductos);
            pProductos.Dock = DockStyle.Top;
            pProductos.Location = new Point(0, 111);
            pProductos.Name = "pProductos";
            pProductos.Size = new Size(647, 270);
            pProductos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(451, 223);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 14;
            label4.Text = "Total Productos :";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(517, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(300, 52);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 10;
            label9.Text = "Cantidad :";
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(119, 51);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(145, 23);
            comboBoxProductos.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 52);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 7;
            label6.Text = "Producto :";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(377, 51);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 6;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(579, 225);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(13, 15);
            lbltotal.TabIndex = 5;
            lbltotal.Text = "0";
            // 
            // dgvListaProductos
            // 
            dgvListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaProductos.BackgroundColor = SystemColors.Control;
            dgvListaProductos.BorderStyle = BorderStyle.None;
            dgvListaProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 173, 138);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaProductos.ColumnHeadersHeight = 30;
            dgvListaProductos.EnableHeadersVisualStyles = false;
            dgvListaProductos.GridColor = SystemColors.Control;
            dgvListaProductos.Location = new Point(41, 90);
            dgvListaProductos.Name = "dgvListaProductos";
            dgvListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaProductos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = Color.DimGray;
            dgvListaProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvListaProductos.RowTemplate.Height = 25;
            dgvListaProductos.Size = new Size(551, 116);
            dgvListaProductos.TabIndex = 4;
            dgvListaProductos.CellClick += dgvListaProductos_CellClick;
            dgvListaProductos.CellContentClick += dgvListaProductos_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(ckbPruductos);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(647, 61);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 22);
            label2.Name = "label2";
            label2.Size = new Size(123, 17);
            label2.TabIndex = 4;
            label2.Text = "Agregar Productos";
            // 
            // ckbPruductos
            // 
            ckbPruductos.AutoSize = true;
            ckbPruductos.Location = new Point(41, 25);
            ckbPruductos.Name = "ckbPruductos";
            ckbPruductos.Size = new Size(15, 14);
            ckbPruductos.TabIndex = 2;
            ckbPruductos.UseVisualStyleBackColor = true;
            ckbPruductos.CheckedChanged += ckbPruductos_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblIdCita);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(ckbEstadoCita);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(647, 50);
            panel3.TabIndex = 8;
            // 
            // lblIdCita
            // 
            lblIdCita.AutoSize = true;
            lblIdCita.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdCita.Location = new Point(417, 19);
            lblIdCita.Name = "lblIdCita";
            lblIdCita.Size = new Size(80, 17);
            lblIdCita.TabIndex = 2;
            lblIdCita.Text = "Codigo CIta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 0;
            label1.Text = "Finalizada :";
            // 
            // ckbEstadoCita
            // 
            ckbEstadoCita.AutoSize = true;
            ckbEstadoCita.Location = new Point(125, 22);
            ckbEstadoCita.Name = "ckbEstadoCita";
            ckbEstadoCita.Size = new Size(15, 14);
            ckbEstadoCita.TabIndex = 1;
            ckbEstadoCita.UseVisualStyleBackColor = true;
            // 
            // FrmDetalleDeCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 821);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmDetalleDeCita";
            Text = "FrmDetalleDeCita";
            Load += FrmDetalleDeCita_Load;
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            pServicios.ResumeLayout(false);
            pServicios.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pProductos.ResumeLayout(false);
            pProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private CheckBox ckbPruductos;
        private Panel pProductos;
        private Panel panel4;
        private DataGridView dgvListaProductos;
        private Panel panel3;
        private Label label1;
        private CheckBox ckbEstadoCita;
        private Panel panel5;
        private Label label3;
        private CheckBox ckbServicio;
        private Label label7;
        private Label lbltotal;
        private TextBox txtCantidad;
        private Button btnAgregar;
        private Label label9;
        private ComboBox comboBoxProductos;
        private Label label6;
        private Label lbltotalCita;
        private Panel pServicios;
        private Panel panel7;
        private TreeView tServicio;
        private TextBox txtPrecio;
        private Button btnGuardar;
        public Label lblIdCita;
        private Label label5;
        private Label label4;
    }
}