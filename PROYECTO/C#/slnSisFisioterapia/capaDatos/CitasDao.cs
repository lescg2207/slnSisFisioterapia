using entidades;
using entidades.Vistas;
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

        public List<Cita> ObtenerCita()
        {
            var prod = (from e in _dbContext.Set<Cita>()
                        select new Cita
                        {
                            idCita = e.idCita,
                            dniPaciente = e.dniPaciente,
                            idEmpleado = e.idEmpleado,
                            fCita = Convert.ToDateTime(e.fCita.ToString()),
                            hCita = e.hCita,
                            estadoPago = Convert.ToInt32(e.estadoPago.ToString()),
                            descuento = Convert.ToDecimal(e.descuento.ToString("0.00")),
                            total = Convert.ToDouble(e.total.ToString())
                        }).ToList();

            return prod;
        }
    }
}
