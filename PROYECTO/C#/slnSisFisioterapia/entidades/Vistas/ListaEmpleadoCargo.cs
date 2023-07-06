using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.Vistas
{
    public class ListaEmpleadoCargo
    {
        public int CODIGO { get; set; }
        public string NOMBRE { get; set; } = null!;

        public string APELLIDOS { get; set; } = null!;

        public string USUARIO { get; set; } = null!;

        public string CARGO { get; set; } = null!;
        public int IDCARGO { get; set; }

        public string CONTRASEÑA { get; set; } = null!;
    }
}
