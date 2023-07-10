using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class DtalleCitaServicios
    {
        public int CODIGO { get; set; }
        public string SERVICIO { get; set; } = null!;
        public int CANTIDAD { get; set; }

        public decimal PRECIO { get; set; }
        public decimal SUBTOTAL { get; set; }
    }
}
