using entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class DetalleCitaDao
    {
        private readonly DbContext _dbContext;

        public DetalleCitaDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void InsertarDetalle(DetalleCita detCita)
        {
            _dbContext.Set<DetalleCita>().Add(detCita);
            _dbContext.SaveChanges();
        }
    }
}
