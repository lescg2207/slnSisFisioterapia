using entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CitasDao
    {
        private readonly DbContext _dbContext;

        public CitasDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Horario> ObtenerHorario()
        {
            return _dbContext.Set<Horario>().ToList();
        }

        public void InsertarCita(Cita Citas)
        {
            
            _dbContext.Set<Cita>().Add(Citas);
            _dbContext.SaveChanges();
        }


    }
}
