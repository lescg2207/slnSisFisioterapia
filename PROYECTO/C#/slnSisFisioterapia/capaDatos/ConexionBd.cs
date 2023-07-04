using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using Microsoft.EntityFrameworkCore;
using static entidades.Enums;

namespace capaDatos
{
    public class ConexionBd: DbContext
    {
        private readonly string _connectionString = null!;
        private readonly string _providerName;
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Horario> Horario { get; set; }

        public ConexionBd(DbContextOptions<ConexionBd> options, string providerName) : base(options)
        {
            _providerName = providerName;
        }

        public ConexionBd(DbContextOptions<ConexionBd> options, string providerName, string connectionString) : base(options)
        {
            _providerName = providerName;
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
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
        }

       

    }
    
}
