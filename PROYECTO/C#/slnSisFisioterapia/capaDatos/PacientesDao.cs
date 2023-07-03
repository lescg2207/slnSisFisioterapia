using entidades;
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
        public List<ListaPacienteHistoria> ObtenerListaPacientes(string providerName)
        {
            var pacientesConHistoriaClinica = _dbContext.Set<Paciente>()
                .Join(_dbContext.Set<HistoriaClinica>(), p => p.dniPaciente, h => h.dniPaciente, (p, h) => new ListaPacienteHistoria
                {
                    HISTORIA = h.idHistoria,
                    DNI = p.dniPaciente,
                    NOMBRES = p.Nombres,
                    APELLIDOS = p.Apellidos,
                    DIRECCION = p.Direccion,
                    FNACIMIENTO = p.FNacimiento,
                    CELULAR = p.Celular,
                    ANTECEDENTES = h.antecedentes,
                    PESO = h.peso,
                    TALLA = h.talla,
                    IMC = h.imc
                })
                .ToList();

            return pacientesConHistoriaClinica;
        }
    }
}
