using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Cita
    {
 
        public int idCita {  get; set; }
        public string dniPaciente { get; set; } = null!;
        public int idEmpleado { get; set; }
        public DateTime fCita { get; set; }
        public int estadoPago { get; set; }
        public decimal descuento { get; set; }
        public SqlMoney total { get; set; }
        public string estadoCita { get; set; } = null!;

    }
}
