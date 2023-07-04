using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Horario
    {
        [Key]
        public int idHorario { get; set; }
        public string horario { get; set; } = null!;
        public int estado { get; set; }
    }
}
