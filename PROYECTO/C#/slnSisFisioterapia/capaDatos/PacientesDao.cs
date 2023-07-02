using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace capaDatos
{
    public class PacientesDao
    {
        private readonly DbContext _dbContext;

        public PacientesDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void InsertarPaciente(Paciente Pacientes)
        {
            _dbContext.Set<Paciente>().Add(Pacientes);
            _dbContext.SaveChanges();
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            
            var pacienteExistente = _dbContext.Set<Paciente>().Find(paciente.dniPaciente);

            if (pacienteExistente != null)
            {
                
                pacienteExistente.Nombres = paciente.Nombres;
                pacienteExistente.Apellidos = paciente.Apellidos;
                pacienteExistente.Direccion = paciente.Direccion;
                pacienteExistente.FNacimiento = paciente.FNacimiento;
                pacienteExistente.Celular = paciente.Celular;

                _dbContext.SaveChanges();
            }
        }
        public List<Paciente> ObtenerListaPacientes()
        {
            return _dbContext.Set<Paciente>().ToList();
        }
    }
}
