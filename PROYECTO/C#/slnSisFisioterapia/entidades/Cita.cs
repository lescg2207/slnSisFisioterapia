using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Cita
    {

        [Key]
        public int idCita {  get; set; }
        public string dniPaciente { get; set; } = null!;
        public int idEmpleado { get; set; }
        public DateTime fCita { get; set; }
        public int hCita { get; set; } 
        public int estadoPago { get; set; }
        public decimal total { get; set; }
        public bool estadoCita { get; set; }

    }
}
