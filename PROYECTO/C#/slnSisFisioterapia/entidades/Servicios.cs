using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Servicios
    {
        [Key]
        public string IdServ { get; set; } = null!;
        public string servicio { get; set; } = null!;
        public string precio { get; set; } = null!;
    }
}
