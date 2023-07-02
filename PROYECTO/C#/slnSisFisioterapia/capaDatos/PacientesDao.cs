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
    }
}
