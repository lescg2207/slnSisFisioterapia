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
    public class ServicioBll:DbContext
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly ServicioDao _serviciosDao;

        public ServicioBll(string providerName, string connectionString)
        {
            _providerName = providerName;
            _connectionString = connectionString;
            _serviciosDao = new ServicioDao(CreateDbContext());
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
        public List<ServicioSesiones> ObtenerTreeNodes()
        {
            return _serviciosDao.ObtenerTreeNodes();
        }

        public List<Servicio> ObtenerServicios()
        {
            return _serviciosDao.ObtenerServicios();
        }

        public void AgregarServicio(ServicioSesiones sesiones)
        {
            _serviciosDao.AgregarServicio(sesiones);
        }
        public void ActualizarCostoSesiones(Sesiones sesiones)
        {
            _serviciosDao.ActualizarCostoSesiones(sesiones);
        }
        public void ActualizarCostoServicio(string nombreServicio, decimal nuevoPrecio)
        {
            _serviciosDao.ActualizarCostoServicio(nombreServicio,nuevoPrecio);
        }

        public List<Sesiones> ObtenerSesiones(int idTipo)
        {
            return _serviciosDao.ObtenerSesiones(idTipo);
        }
    }
}
