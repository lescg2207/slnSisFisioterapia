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
            return _dbContext.Set<Horario>().Where(e => e.estado == true).ToList();
        }

        public List<Cita> ObtenerCitas()
        {
            return _dbContext.Set<Cita>().ToList();
        }

        public void InsertarCita(Cita Citas)
        {
            
            _dbContext.Set<Cita>().Add(Citas);
            _dbContext.SaveChanges();
        }

        public List<ListaCitaPacHorario> ListarCitaEmPaHo()
        {
            var citaspac = (from c in _dbContext.Set<Cita>()join h in _dbContext.Set<Horario>()on c.hCita equals h.idHorario join e in _dbContext.Set<Empleado>()on c.idEmpleado equals e.IdEmpleado select new ListaCitaPacHorario {
            
                CODIGO=c.idCita,
                PACIENTE=c.dniPaciente,
                DOCTOR=e.Nombres+" "+e.Apellidos,
                FECHA=c.fCita,
                HORA=h.horario,
                PAGO = (c.estadoPago == 0) ? "Pendiente" : "Pagado",
                TOTAL=Convert.ToDecimal(c.total.ToString("0.00")),
                FINALIZADA=c.estadoCita
            
            }).ToList();
            
            return citaspac;
        }
        public void actualizarEstadoHorario( Horario hora)
        {
            var horarioEstado=_dbContext.Set<Horario>().Find(hora.idHorario);
            if (horarioEstado != null)
            {
                horarioEstado.estado = hora.estado;
                _dbContext.SaveChanges();
            }

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
                            total = Convert.ToDecimal(e.total.ToString("0.00"))
                        }).ToList();

            return prod;
        }
    }
}
