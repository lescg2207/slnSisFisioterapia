using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Sesiones
    {
        [Key]
        public int idSesion { get; set; }
        public int idTipo { get; set; } = 0!;
        public int sesiones { get; set; } = 0!;
        public decimal precio { get; set; }
    }
}
