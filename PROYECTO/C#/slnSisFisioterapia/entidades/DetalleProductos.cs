using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class DetalleProductos
    {
        [Key]
        public int idDetalle { get; set; }
        public int idCita { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioU { get; set; } = 0!;
        public decimal subtotal { get; set;} =0!;


    }
}
