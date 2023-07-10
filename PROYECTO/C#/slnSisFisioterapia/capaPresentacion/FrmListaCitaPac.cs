﻿using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
using System.Runtime.InteropServices;

namespace capaPresentacion
{
    public partial class FrmListaCitaPac : Form
    {
        private CitasBll _citaBll;
        private string gestor, conexion;


        public FrmListaCitaPac(string gest, string cone)
        {
            _citaBll = new CitasBll(gest, cone);
            this.gestor = gest;
            this.conexion = cone;
            InitializeComponent();
            CargarCitas();
        }

        void CargarCitas()
        {
            List<ListaCitaPacHorario> tabla = _citaBll.ListarCitaEmPaHo();
            dgvCitas.DataSource = tabla;
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            boton.HeaderText = "EDITAR";
            boton.Name = "btnEditar";
            boton.UseColumnTextForButtonValue = true;
            dgvCitas.Columns.Add(boton);


        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas(gestor, conexion);
            citas.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCitas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    FrmDetalleDeCita detalleDeCita = new FrmDetalleDeCita(gestor,conexion);
                    detalleDeCita.lblIdCita.Text = dgvCitas.CurrentRow.Cells[1].Value.ToString();
                    detalleDeCita.Show();
                }
            }
        }
    }
}