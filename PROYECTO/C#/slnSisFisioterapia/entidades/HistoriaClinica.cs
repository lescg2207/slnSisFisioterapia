using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class HistoriaClinica
    {
        [Key]
        public int Id { get; set; } 
        public string idHistoria { get; set; } = null!;
        public string dniPaciente { get; set; } = null!;
        public string? antecedentes { get; set; }
        public decimal peso { get; set; }
        public decimal talla { get; set; }
        public decimal imc { get; set; }
        public string? observaciones { get; set; }

        private static int counter = 0;

        public void GenerateIdHistoria()
        {
            idHistoria = "HC" + GenerateUniqueNumber().ToString().PadLeft(5, '0');
        }

        private int GenerateUniqueNumber()
        {
            // Incrementa el contador y devuelve su valor
            return ++counter;
        }

    }
}
