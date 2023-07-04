using entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class EmpleadoDao
    {
        private readonly DbContext _dbContext;

        public EmpleadoDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Empleado> ObtenerEmpleado()
        {
            var empleados = _dbContext.Set<Empleado>()
        .Select(e => new Empleado
        {
            IdEmpleado = e.IdEmpleado,
            Nombres = e.Nombres + " " + e.Apellidos
        })
        .ToList();

            return empleados;
        }

    }
}
