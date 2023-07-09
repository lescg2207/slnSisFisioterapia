using capaDatos;
using entidades;
using entidades.Vistas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class CitasBll
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly CitasDao _CitasDao;

        public CitasBll(string providerName, string connectionString)
        {
            _providerName = providerName;
            _connectionString = connectionString;
            _CitasDao = new CitasDao(CreateDbContext());
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

        public List<Horario> ObtenerHorario()
        {
            return _CitasDao.ObtenerHorario();
        }

        public void InsertarCitas(Cita citas)
        {
            _CitasDao.InsertarCita(citas);
        }
        public List<Cita> ObtenerCitas()
        {
            return _CitasDao.ObtenerCitas();
        }

        public List<ListaCitaPacHorario> ListarCitaEmPaHo()
        {
            return _CitasDao.ListarCitaEmPaHo();
        }
        public void actualizarEstadoHorario(Horario hora)
        {
            _CitasDao.actualizarEstadoHorario(hora);
        }

        public List<Cita> ObtenerCita()
        {
            return _CitasDao.ObtenerCita();
        }
    }
}
