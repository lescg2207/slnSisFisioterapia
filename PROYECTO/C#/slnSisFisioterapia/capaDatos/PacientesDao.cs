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

        public void InsertarPacienteHistoria(HistoriaClinica historiaClinica)
        {
            historiaClinica.GenerateIdHistoria();
            _dbContext.Set<HistoriaClinica>().Add(historiaClinica);
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

        public void InsertarPacienteConHistoriaClinica(Paciente paciente, HistoriaClinica historiaClinica)
        {
            using (var dbContext = new BDFisioContext())
            {
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        dbContext.Pacientes.Add(paciente);
                        dbContext.SaveChanges();

                        historiaClinica.dniPaciente = paciente.dniPaciente;
                        dbContext.HistoriaClinica.Add(historiaClinica);
                        dbContext.SaveChanges();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
