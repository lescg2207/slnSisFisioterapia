using entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class DescuentosDao
    {
        private readonly DbContext _dbContext;


        public DescuentosDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Descuento> ObtenerDescuentos()
        {
            var descuentos = _dbContext.Set<Descuento>()
                               .OrderByDescending(d => d.valorDescuento)
                               .Select(d => new Descuento
                               {
                                   nombreDescuento = d.nombreDescuento,
                                   valorDescuento = d.valorDescuento
                               })
                               .ToList();

            return descuentos;
        }

        public void AgregarDescuento(Descuento descuento)
        {
            _dbContext.Set<Descuento>().Add(descuento);
            _dbContext.SaveChanges();
        }

        public void ActualizarDescuento(Descuento descuento)
        {
            var descuentoExistente = _dbContext.Set<Descuento>().FirstOrDefault(d => d.nombreDescuento == descuento.nombreDescuento);

            if (descuentoExistente != null)
            {
                descuentoExistente.valorDescuento = descuento.valorDescuento;
                _dbContext.SaveChanges(); // Guardar los cambios en la base de datos
            }
        }
    }
}
