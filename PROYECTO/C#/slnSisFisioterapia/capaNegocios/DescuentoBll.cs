using capaDatos;
using entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class DescuentoBll
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly DescuentosDao _descuentosDao;

        public DescuentoBll(string providerName, string connectionString)
        {
            _providerName = providerName;
            _connectionString = connectionString;
            _descuentosDao = new DescuentosDao(CreateDbContext());
        }
        private DbContext CreateDbContext()
        {
            DbContextOptionsBuilder<ConexionBd> optionsBuilder = new DbContextOptionsBuilder<ConexionBd>();

            switch (_providerName)
            {
                case "SqlServer":
                    optionsBuilder.UseSqlServer(_connectionString);
                    break;
                case "MySql":
                    optionsBuilder.UseMySql(_connectionString, new MySqlServerVersion(new Version(8, 0, 32)));
                    break;
                default:
                    break;
            }

            return new ConexionBd(optionsBuilder.Options, _providerName, _connectionString);
        }

        public List<Descuento> ObtenerDescuentos()
        {
            return _descuentosDao.ObtenerDescuentos();
        }
        public void AgregarDescuento(Descuento descuento)
        {
            _descuentosDao.AgregarDescuento(descuento);
        }
        public void ActualizarDescuento(Descuento descuento)
        {
            _descuentosDao.ActualizarDescuento(descuento);
        }

        public List<Impuesto> ObtenerImpuesto()
        {
            return _descuentosDao.ObtenerImpuesto();
        }

        public void AgregarImpuesto(Impuesto impuesto)
        {
            _descuentosDao.AgregarImpuesto(impuesto);
        }
        public void ActualizarImpuesto(Impuesto impuesto)
        {
            _descuentosDao.ActualizarImpuesto(impuesto);
        }
    }
}
