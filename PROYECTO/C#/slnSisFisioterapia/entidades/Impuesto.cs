using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Impuesto
    {
        [Key]
        public int idImpuesto { get; set; }
        public string impuesto { get; set; } = null!;
        public decimal porcentaje { get; set; }
    }
}
