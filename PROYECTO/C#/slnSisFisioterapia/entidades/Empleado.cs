using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; }=null!;
        public int IdCargo { get; set; }
    }
}
