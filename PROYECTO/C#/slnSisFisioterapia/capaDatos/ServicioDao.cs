using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net;
using static System.Collections.Specialized.BitVector32;
using entidades.Vistas;

namespace capaDatos
{
    public class ServicioDao
    {
        private readonly DbContext _dbContext;


        public ServicioDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ServicioSesiones> ObtenerTreeNodes()
        {
            var treeNodes = (from se in _dbContext.Set<Servicio>()
                             join ss in _dbContext.Set<Sesiones>() on se.IdServicio equals ss.idTipo into sesionesJoin
                             from ssJoin in sesionesJoin.DefaultIfEmpty()
                             select new ServicioSesiones
                             {
                                 SERVICIO = se.servicio,
                                 PRECIOServ = se.precio.ToString(),
                                 IDTIPO = ssJoin != null ? ssJoin.idTipo.ToString() : string.Empty,
                                 SESIONES = ssJoin != null ? ssJoin.sesiones.ToString() : string.Empty,
                                 PRECIO = ssJoin != null ? ssJoin.precio.ToString() : string.Empty
                             }).ToList();

            return treeNodes;
        }

        public List<Servicio> ObtenerServicios()
        {
            var serv = (from e in _dbContext.Set<Servicio>()
                        select new Servicio
                        {
                            IdServicio = e.IdServicio,
                            servicio = e.servicio,
                            precio = Convert.ToDecimal(e.precio.ToString("0.00")),
                        }).ToList();

            return serv;
        }

        public void AgregarServicio(ServicioSesiones servicioSesiones)
        {
            // Obtener el ID correspondiente al tipo de servicio seleccionado
            int idTipo = _dbContext.Set<Servicio>().FirstOrDefault(s => s.servicio == servicioSesiones.SERVICIO)?.IdServicio ?? 0;

            // Crear una instancia de la entidad Sesiones y asignar los valores
            Sesiones sesiones = new Sesiones
            {
                idTipo = idTipo,
                sesiones = int.Parse(servicioSesiones.SESIONES),
                precio = decimal.Parse(servicioSesiones.PRECIO)
            };

            // Agregar la entidad Sesiones y guardar los cambios en la base de datos
            _dbContext.Set<Sesiones>().Add(sesiones);
            _dbContext.SaveChanges();
        }

        public void ActualizarCostoSesiones(Sesiones sesiones)
        {
            var sesionExistente = _dbContext.Set<Sesiones>().FirstOrDefault(s => s.sesiones == sesiones.sesiones);

            if (sesionExistente != null)
            {
                sesionExistente.precio = sesiones.precio;
                _dbContext.SaveChanges();
            }
        }
        public void ActualizarCostoServicio(string nombreServicio, decimal nuevoPrecio)
        {
            var servicioExistente = _dbContext.Set<Servicio>().FirstOrDefault(s => s.servicio == nombreServicio);

            if (servicioExistente != null)
            {
                servicioExistente.precio = nuevoPrecio;
                _dbContext.SaveChanges(); // Guardar los cambios en la base de datos
            }
        }

    }
}
