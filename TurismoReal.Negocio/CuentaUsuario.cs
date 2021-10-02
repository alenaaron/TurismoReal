using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.DALC;

namespace TurismoReal.Negocio
{
    public class CuentaUsuario
    {
        public decimal id_cuenta_usuario { get; set; }
        public string email_usuario { get; set; }
        public string password { get; set; }
        public DateTime fecha_creacion { get; set; }
        public decimal tipo_usuario_id_tipo_usuario { get; set; }

        public TipoUsuario tipoUsuario { get; set; }
    }
}
