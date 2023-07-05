using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net;


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
            var pacientesConHistoriaClinica = (from p in _dbContext.Set<Paciente>()join h in _dbContext.Set<HistoriaClinica>() on p.dniPaciente equals h.dniPaciente select new ListaPacienteHistoria{HISTORIA=h.idHistoria, DNI=p.dniPaciente,NOMBRES=p.Nombres,APELLIDOS=p.Apellidos,DIRECCION=p.Direccion,FNACIMIENTO=p.FNacimiento,CELULAR=p.Celular,ANTECEDENTES=h.antecedentes,PESO=h.peso,TALLA=h.talla,IMC=h.imc}).ToList();
            return pacientesConHistoriaClinica;
        }

        public List<ListaPacienteHistoria> BuscarPacientePorDNI(string dni)
        {
            var pacientesConHistoriaClinica = (from p in _dbContext.Set<Paciente>()join h in _dbContext.Set<HistoriaClinica>() on p.dniPaciente equals h.dniPaciente where p.dniPaciente.StartsWith(dni) select new ListaPacienteHistoria{HISTORIA=h.idHistoria, DNI=p.dniPaciente,NOMBRES=p.Nombres,APELLIDOS=p.Apellidos,DIRECCION=p.Direccion,FNACIMIENTO=p.FNacimiento,CELULAR=p.Celular,ANTECEDENTES=h.antecedentes,PESO=h.peso,TALLA=h.talla,IMC=h.imc}).ToList();
            return pacientesConHistoriaClinica;           
        }

        public List<ListaPacienteHistoria> BuscarPacientePorNombre(string nombre)
        {
            var pacientesConHistoriaClinica = (from p in _dbContext.Set<Paciente>() join h in _dbContext.Set<HistoriaClinica>() on p.dniPaciente equals h.dniPaciente where p.Nombres.StartsWith(nombre) select new ListaPacienteHistoria { HISTORIA = h.idHistoria, DNI = p.dniPaciente, NOMBRES = p.Nombres, APELLIDOS = p.Apellidos, DIRECCION = p.Direccion, FNACIMIENTO = p.FNacimiento, CELULAR = p.Celular, ANTECEDENTES = h.antecedentes, PESO = h.peso, TALLA = h.talla, IMC = h.imc }).ToList();
            return pacientesConHistoriaClinica;
        }

        public List<ListaPacienteHistoria> BuscarPacientePorApellido(string apellido)
        {
            var pacientesConHistoriaClinica = (from p in _dbContext.Set<Paciente>() join h in _dbContext.Set<HistoriaClinica>() on p.dniPaciente equals h.dniPaciente where p.Apellidos.StartsWith(apellido) select new ListaPacienteHistoria { HISTORIA = h.idHistoria, DNI = p.dniPaciente, NOMBRES = p.Nombres, APELLIDOS = p.Apellidos, DIRECCION = p.Direccion, FNACIMIENTO = p.FNacimiento, CELULAR = p.Celular, ANTECEDENTES = h.antecedentes, PESO = h.peso, TALLA = h.talla, IMC = h.imc }).ToList();
            return pacientesConHistoriaClinica;
        }

        public Empleado ValidarCredenciales(string usuario, string contraseña)
        {

            var empleado = _dbContext.Set<Empleado>().FirstOrDefault(e => e.Usuario == usuario && e.Contraseña == contraseña);
            return empleado!;
        }

        
    }
}
