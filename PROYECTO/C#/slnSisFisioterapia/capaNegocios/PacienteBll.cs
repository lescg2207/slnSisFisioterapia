﻿using capaDatos;
using entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class PacienteBll : DbContext
    {
        public PacienteBll(BDFisioContext dbContext)
        {
            pacientesDao = new PacientesDao(dbContext);
        }
        private PacientesDao pacientesDao;
        //PacientesDao pacientesDao = new PacientesDao(new BDFisioContext());


        public void InsertarPaciente(Paciente nuevoPaciente)
        {
            pacientesDao.InsertarPaciente(nuevoPaciente);
        }

        public void ActualizarPaciente(Paciente upPaciente)
        {
            pacientesDao.ActualizarPaciente(upPaciente);
        }

        public List<ListaPacienteHistoria> ObtenerListaPacientes()
        {
            return pacientesDao.ObtenerListaPacientes();
        }
        

        public void InsertarPacienteHistoria(HistoriaClinica historia)
        {
            pacientesDao.InsertarPacienteHistoria(historia);
        }
    }
}
