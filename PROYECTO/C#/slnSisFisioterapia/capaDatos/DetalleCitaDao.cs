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

        public void InsertarDetalleProducto(DetalleCita productos)
        {
            _dbContext.Set<DetalleCita>().Add(productos);
            _dbContext.SaveChanges();
        }

        public void InsertarDetalleServicioo(DetalleCita servicio)
        {
            _dbContext.Set<DetalleCita>().Add(servicio);
            _dbContext.SaveChanges();
        }
        public List<DetalleCita> ListarProductos(int idCita)
        {
            var Productos=( from p in _dbContext.Set<DetalleCita>() where p.idCita == idCita  select new DetalleCita
            {
                idDetalle=p.idDetalle,
                idCita=p.idCita,
                idProducto=p.idProducto,
                cantidad=p.cantidad,
                precioU=p.precioU,
                subtotal=p.subtotal,
            }
                ).ToList();
            return Productos;
            
        }

        public void ActualizarTotalCita(Cita cita)
        {
            var totalExistente = _dbContext.Set<Cita>().Find(cita.idCita);
            if(totalExistente != null)
            {
                totalExistente.total=cita.total;
                totalExistente.estadoCita=cita.estadoCita;
                _dbContext.SaveChanges();
            }
        }
        
    }
}
