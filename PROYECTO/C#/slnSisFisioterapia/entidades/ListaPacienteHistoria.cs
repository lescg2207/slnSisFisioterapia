using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class ListaPacienteHistoria
    { 
        public string dniPaciente { get; set; } = null!;

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public DateTime FNacimiento { get; set; }

        public string Celular { get; set; } = null!;

              
        public string idHistoria { get; set; } = null!;

        public string? antecedentes { get; set; }
        public decimal peso { get; set; }
        public decimal talla { get; set; }
        public decimal imc { get; set; }



    }
}
