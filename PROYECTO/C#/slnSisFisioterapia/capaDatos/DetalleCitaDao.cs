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

       
        /* public void RealizarTransaccion(List<Servicio> servicios, List<Productos> productos)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    // Insertar servicios en la tabla Servicio
                    _dbContext.Set<Servicio>().AddRange(servicios);

                    // Insertar productos en la tabla Producto
                    _dbContext.Set<Productos>().AddRange(productos);

                    // Guardar cambios en la base de datos
                    _dbContext.SaveChanges();

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Manejar errores y revertir la transacción en caso de excepción
                    transaction.Rollback();
                    throw;
                }
            }

        }
    */

        public void InsertarDetalleProducto(DetalleProductos productos)
        {
            _dbContext.Set<DetalleProductos>().Add(productos);
            _dbContext.SaveChanges();
        }

        public void InsertarDetalleServicioo(DetalleServicio servicio)
        {
            _dbContext.Set<DetalleServicio>().Add(servicio);
            _dbContext.SaveChanges();
        }
        public List<DetalleProductos> ListarProductos(int idCita)
        {
            var Productos=( from p in _dbContext.Set<DetalleProductos>() where p.idCita == idCita  select new DetalleProductos
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
    }
}
