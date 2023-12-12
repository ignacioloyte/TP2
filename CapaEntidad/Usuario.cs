using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }  

        public string Email { get; set; }
        public string Clave { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public Rol oRol { get; set; }
        public bool Estado {  get; set; }
    }
}
