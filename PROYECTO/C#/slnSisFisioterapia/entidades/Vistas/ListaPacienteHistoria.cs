using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class ListaPacienteHistoria
    {
        
        public string HISTORIA { get; set; } = null!;

        public string DNI { get; set; } = null!;

        public string NOMBRES { get; set; } = null!;

        public string APELLIDOS { get; set; } = null!;

        public string DIRECCION { get; set; } = null!;

        public DateTime FNACIMIENTO { get; set; }

        public string CELULAR { get; set; } = null!;
     
        public string? ANTECEDENTES { get; set; }
        public decimal PESO { get; set; }
        public decimal TALLA { get; set; }
        public decimal IMC { get; set; }

        public int IDHistoria { get; set; }
        public string observaciones { get; set; } = null!;

    }
}
