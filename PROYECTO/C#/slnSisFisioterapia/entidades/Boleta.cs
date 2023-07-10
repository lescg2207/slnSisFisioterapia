using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Boleta
    {
        public int Id { get; set; }
        public int idCita { get; set; }
        public string dniPaciente { get; set; } = null!;
        public string metodoPago { get; set; }=null!;
        public decimal subtotal { get; set; }
        public int? idImpuesto { get; set; }
        public int? idDescuento { get; set; }
        public decimal total { get; set; }
        public DateTime fpago { get; set; }

    }
}
