using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Negocio
{
    public class Usuario
    {
        public string rut_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public decimal cuenta_usuario_id_cuenta_usuario { get; set; }

        public CuentaUsuario cuentaUsuario { get; set; }
    }
}
