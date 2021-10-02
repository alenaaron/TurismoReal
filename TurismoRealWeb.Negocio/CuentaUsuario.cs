using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;

namespace TurismoRealWeb.Negocio
{
    public class CuentaUsuario
    {
        public decimal idCuentaUsuario { get; set; }
        public String emailUsuario { get; set; }
        public String passwordUsuario { get; set; }
        public DateTime fechaCreacion { get; set; }
        public TipoUsuario tipoUsuario { get; set; }

        TurismoRealEntities db = new TurismoRealEntities();
        public bool Autenticar()
        {
            return db.CUENTA_USUARIO
                .Where(cu => cu.EMAIL_USUARIO == this.emailUsuario && cu.PASSWORD_USUARIO == this.passwordUsuario)
                .FirstOrDefault() != null;
        }
    }
}
