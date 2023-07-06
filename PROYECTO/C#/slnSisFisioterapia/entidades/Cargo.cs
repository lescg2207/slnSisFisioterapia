using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Cargo
    {
        [Key]
        public int idCargo { get; set; }
        public string cargo { get; set; } = null!;
    }
}
