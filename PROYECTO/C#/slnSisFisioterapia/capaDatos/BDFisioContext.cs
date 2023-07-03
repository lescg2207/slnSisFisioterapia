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
    public class BDFisioContext: DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cita> Citas { get; set; }

        private GestorBaseDatos _selectedGestor;

        public BDFisioContext(GestorBaseDatos selectedGestor)
        {
            _selectedGestor = selectedGestor;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_selectedGestor == GestorBaseDatos.SqlServer)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=BDFisio;User Id=sa;Password=les123;TrustServerCertificate=true;");
            }
            else if (_selectedGestor == GestorBaseDatos.MySql)
            {
                optionsBuilder.UseMySql("Server=localhost;Uid=root;Pwd=admin;Database=bdfisio",
                        new MySqlServerVersion(new Version(8, 0, 32)));
            }
            // Agrega aquí otros casos para diferentes gestores de base de datos

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones adicionales del modelo

            base.OnModelCreating(modelBuilder);
        }


    }
    
}
