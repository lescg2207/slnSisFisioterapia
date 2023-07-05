using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net;
using static System.Collections.Specialized.BitVector32;

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
            var treeNodes = (from se in _dbContext.Set<Servicios>()
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
    }
}
