using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using static entidades.Enums;

namespace capaDatos
{
    public class BDFisioContext: DbContext
    {
        private readonly string _connectionString = null!;
        private readonly string _providerName;
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cita> Citas { get; set; }


        public BDFisioContext(DbContextOptions<BDFisioContext> options, string providerName) : base(options)
        {
            _providerName = providerName;
        }

        public BDFisioContext(DbContextOptions<BDFisioContext> options, string providerName, string connectionString) : base(options)
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
