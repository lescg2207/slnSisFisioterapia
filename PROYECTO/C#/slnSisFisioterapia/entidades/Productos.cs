using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    internal class Productos
    {
        [Key]
        public int idProducto { get; set; } = 0!;

        public string nomProducto { get; set; } = null!;

        public double precio { get; set; } = 0!;

        public int stock { get; set; } = 0!;
    }
}
