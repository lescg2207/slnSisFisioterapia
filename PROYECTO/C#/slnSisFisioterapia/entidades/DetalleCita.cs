using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class DetalleCita
    {
        [Key]
        public int idDetalle { get; set; }
        public int idCita { get; set; } = 0!;
        public int idServicio { get; set; } = 0!;
        public int? idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioU { get; set; }
        public decimal subtotal { get; set; }
        public int? idImpuesto { get; set; }
    }
}
