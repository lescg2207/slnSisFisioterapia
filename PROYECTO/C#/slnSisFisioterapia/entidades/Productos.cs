using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        public int idProducto { get; set; }

        public string nomProducto { get; set; } = null!;

        public decimal precio { get; set; } = 0!;

        public int stock { get; set; } = 0!;
    }
}
