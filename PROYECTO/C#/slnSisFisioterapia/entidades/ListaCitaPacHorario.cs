using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class ListaCitaPacHorario
    {

        public int CODIGO { get; set; }
        public string PACIENTE { get; set; } = null!;
        public string DOCTOR { get; set; } = null!;
        public DateTime FECHA { get; set; }
        public string HORA { get; set; } = null!;
        public string PAGO { get; set; } = null!;
        public decimal TOTAL { get; set; }       
        public decimal IMPUESTO { get; set; }
        public decimal DESCUENTO { get; set; }
        public bool FINALIZADA { get; set; }

    }
}
