using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using Microsoft.EntityFrameworkCore;

namespace capaDatos
{
    public class BDFisioContext: DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cita> Citas { get; set; }
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=localhost;Database=BDFisio;User Id=sa;Password=les123;TrustServerCertificate=true;");
            optionsBuilder.UseMySql("Server=localhost;Uid=root;Pwd=admin;Database=bdfisio",
                        new MySqlServerVersion(new Version(8, 0, 32)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

        
    }
    
}
