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
            historiaClinica.idHistoria = GenerateUniqueNumber();
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
        /*public List<Paciente> ObtenerListaPacientes()
        {
            //return _dbContext.Set<Paciente>().Include(p => p.HistoriaClinica).ToList();
        }*/

        private string GenerateUniqueNumber()
        {
            var lastRecord = _dbContext.Set<HistoriaClinica>()
                .OrderByDescending(h => h.Id)
                .FirstOrDefault();

            if (lastRecord != null)
            {
                int lastNumber = int.Parse(lastRecord.idHistoria.Substring(2));
                int newNumber = lastNumber + 1;
                return $"HC{newNumber.ToString().PadLeft(5, '0')}";
            }

            return "HC00001";
        }
        public List<ListaPacienteHistoria> ObtenerListaPacientes()
        {
            var pacientesConHistoriaClinica = (from p in _dbContext.Set<Paciente>()
                                               join h in _dbContext.Set<HistoriaClinica>() on p.dniPaciente equals h.dniPaciente
                                               select new ListaPacienteHistoria
                                               {
                                                   Pacientes = p,
                                                   HistoriaClinica = h
                                               }).ToList();

            return pacientesConHistoriaClinica;
        }
    }
}
