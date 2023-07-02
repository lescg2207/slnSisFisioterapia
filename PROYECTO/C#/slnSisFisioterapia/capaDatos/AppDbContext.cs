using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;
using Microsoft.EntityFrameworkCore;

namespace capaDatos
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Pacientes
            modelBuilder.Entity<Paciente>().HasKey(p=> p.dniPaciente);
            modelBuilder.Entity<Paciente>().Property(p=> p.Nombres).HasMaxLength(100);
            modelBuilder.Entity<Paciente>().Property(p => p.Apellidos).HasMaxLength(100);
            modelBuilder.Entity<Paciente>().Property(p => p.Direccion).HasMaxLength(200);
            modelBuilder.Entity<Paciente>().Property(p => p.FNacimiento).HasColumnType("date");
            modelBuilder.Entity<Paciente>().Property(p => p.Celular).HasMaxLength(10);

            //Historia Clinica

            modelBuilder.Entity<HistoriaClinica>().HasKey(h=> h.idHistoria);
            modelBuilder.Entity<HistoriaClinica>().Property(h => h.antecedentes).HasMaxLength(200);
            modelBuilder.Entity<HistoriaClinica>().Property(h => h.peso).HasPrecision(5,2);
            modelBuilder.Entity<HistoriaClinica>().Property(h => h.talla).HasPrecision(5, 2);
            modelBuilder.Entity<HistoriaClinica>().Property(h => h.imc).HasPrecision(5, 2);
            modelBuilder.Entity<HistoriaClinica>().Property(h => h.observaciones).HasMaxLength(200);



        }

        public DbSet<Paciente> Pacientes => Set<Paciente>();
        public DbSet<HistoriaClinica> HistoriaClinica => Set<HistoriaClinica>();


    }
}
