using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWeb.DALC;
namespace TurismoRealWeb.Negocio
{
    public class Usuario
    {
        public String rutUsuario { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String email { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public decimal idCuentaUsuario { get; set; }
        public CuentaUsuario cuentaUsuario { get; set; }

        TurismoRealEntities db = new TurismoRealEntities();
        
        public bool Save()
        {
            try
            {
                db.SP_CREATE_USER(this.cuentaUsuario.emailUsuario, this.cuentaUsuario.passwordUsuario, this.rutUsuario, this.nombre, this.apellido, this.direccion, this.telefono);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
