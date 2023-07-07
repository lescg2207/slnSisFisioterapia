using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }
        public string servicio { get; set; } = null!;
        public decimal precio { get; set; } = 0!;
    }
}
