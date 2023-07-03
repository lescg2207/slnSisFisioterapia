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
    public class PacienteBll : DbContext
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly PacientesDao _pacientesDao;

        public PacienteBll(string providerName, string connectionString)
        {
            _providerName = providerName;
            _connectionString = connectionString;
            _pacientesDao = new PacientesDao(CreateDbContext());
        }
        private DbContext CreateDbContext()
        {
            DbContextOptionsBuilder<BDFisioContext> optionsBuilder = new DbContextOptionsBuilder<BDFisioContext>();

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

            return new BDFisioContext(optionsBuilder.Options, _providerName, _connectionString);
        }


        public void InsertarPaciente(Paciente nuevoPaciente)
        {
            _pacientesDao.InsertarPaciente(nuevoPaciente);
        }

        public void ActualizarPaciente(Paciente upPaciente)
        {
            _pacientesDao.ActualizarPaciente(upPaciente);
        }

        public List<ListaPacienteHistoria> ObtenerListaPacientes()
        {
            return _pacientesDao.ObtenerListaPacientes();
        }


        public void InsertarPacienteHistoria(HistoriaClinica historia)
        {
            _pacientesDao.InsertarPacienteHistoria(historia);
        }

        public List<ListaPacienteHistoria> BuscarPacientePorDNI(string dni)
        {
            return _pacientesDao.BuscarPacientePorDNI(dni);
        }

        public List<ListaPacienteHistoria> BuscarPacientePorNombre(string nombre)
        {
            return _pacientesDao.BuscarPacientePorNombre(nombre);
        }
        public List<ListaPacienteHistoria> BuscarPacientePorApellido(string apellido)
        {
            return _pacientesDao.BuscarPacientePorApellido(apellido);
        }
    }
}
