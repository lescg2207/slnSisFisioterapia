using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Descuento
    {
        [Key]
        public int idDescuento { get; set; }

        public string nombreDescuento { get; set; } = null!;

        public decimal valorDescuento { get; set; }
    }
}
