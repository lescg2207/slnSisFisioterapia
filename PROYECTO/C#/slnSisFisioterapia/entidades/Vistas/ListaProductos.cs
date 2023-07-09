using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.Vistas
{
    [Table("Productos")]
    public class ListaProductos
    {

        public int CODIGO { get; set; }
        public string NOMBRE { get; set; } = null!;

        public decimal PRECIO { get; set; } = 0!;

        public int STOCK { get; set; } = 0!;
    }
}
