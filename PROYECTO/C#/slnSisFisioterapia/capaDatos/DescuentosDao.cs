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

        public List<Impuesto> ObtenerImpuesto()
        {
            var impuesto = _dbContext.Set<Impuesto>()
                               .OrderByDescending(d => d.porcentaje)
                               .Select(d => new Impuesto
                               {
                                   impuesto = d.impuesto,
                                   porcentaje = d.porcentaje
                               })
                               .ToList();

            return impuesto;
        }

        public void AgregarImpuesto(Impuesto impuesto)
        {
            _dbContext.Set<Impuesto>().Add(impuesto);
            _dbContext.SaveChanges();
        }

        public void ActualizarImpuesto(Impuesto impuesto)
        {
            var descuentoExistente = _dbContext.Set<Impuesto>().FirstOrDefault(d => d.impuesto == impuesto.impuesto);

            if (descuentoExistente != null)
            {
                descuentoExistente.porcentaje = impuesto.porcentaje;
                _dbContext.SaveChanges(); // Guardar los cambios en la base de datos
            }
        }
    }
}
