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
    public class EmpleadoBll
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly EmpleadoDao _empleadoDa;

        public EmpleadoBll(string providerName, string connectionString)
        {
            _providerName = providerName;
            _connectionString = connectionString;
            _empleadoDa =new EmpleadoDao(CreateDbContext());

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

        public List<Empleado> ObtenerEmpleado()
        {
            return _empleadoDa.ObtenerEmpleado();
        }
        public List<ListaEmpleadoCargo> ListaEmpleadoCargo()
        {
            return _empleadoDa.ListaEmpleadoCargo();
        }

        public List<Cargo> ObtenerEmpleadoCargo()
        {
            return _empleadoDa.ObtenerEmpleadoCargo();
        }
        public void InsertarEmpleado(Empleado Emple)
        {
            _empleadoDa.InsertarEmpleado(Emple);
        }
        public void ActualizarEmpleado(Empleado emple)
        {
            _empleadoDa.ActualizarEmpleado(emple);
        }

        public List<ListaEmpleadoCargo> BuscarEmpleadoCargo(string cargo)
        {
            return _empleadoDa.BuscarEmpleadoCargo(cargo);
         }

        public List<ListaEmpleadoCargo> BuscarEmpleadoNombre(string nombre)
        {
            return _empleadoDa.BuscarEmpleadoNombre(nombre);
        }
    }
}
