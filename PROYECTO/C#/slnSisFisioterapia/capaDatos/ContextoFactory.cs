using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static entidades.Enums;

namespace capaDatos
{
    public class ContextoFactory
    {
        public static DbContext CreateContext(GestorBaseDatos gestor)
        {
            if (gestor == GestorBaseDatos.SqlServer)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
                optionsBuilder.UseSqlServer("Server=localhost;Database=BDFisio;User Id=sa;Password=les123;TrustServerCertificate=true;");
                return new DbContext(optionsBuilder.Options);
            }
            else if (gestor == GestorBaseDatos.MySql)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
                optionsBuilder.UseMySql("Server=localhost;Uid=root;Pwd=admin;Database=bdfisio",
                        new MySqlServerVersion(new Version(8, 0, 32)));
                return new DbContext(optionsBuilder.Options);
            }
            // Agrega aquí otros casos para diferentes gestores de base de datos

            throw new Exception("Gestor de base de datos no soportado");
        }
    }
}
