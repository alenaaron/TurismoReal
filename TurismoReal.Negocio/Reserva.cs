using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.DALC;

namespace TurismoReal.Negocio
{
    public class Reserva
    {
        public decimal id_reserva { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public string firma_conformidad_cliente { get; set; }
        public string usuario_id_usuario { get; set; }

        public Usuario Usuario { get; set; }
        

        TurismoRealWebEntities db = new TurismoRealWebEntities();

        public List<Reserva> ReadAll()
        {
            return this.db.RESERVA.Select(r => new Reserva() {
                id_reserva = r.ID_RESERVA,
                fecha_entrada = (DateTime)r.FECHA_ENTRADA,
                fecha_salida = (DateTime)r.FECHA_SALIDA,
                firma_conformidad_cliente = r.FIRMA_CONFORMIDAD_CLIENTE,
                usuario_id_usuario = r.USUARIO_ID_USUARIO,
                Usuario = new Usuario()
                {
                    rut_usuario = r.USUARIO.RUT_USUARIO,
                    nombre = r.USUARIO.NOMBRE,
                    apellido = r.USUARIO.APELLIDO,
                    email = r.USUARIO.EMAIL,
                    direccion = r.USUARIO.DIRECCION,
                    telefono = r.USUARIO.TELEFONO
                }

            }).ToList();

        }

        public bool Save()
        {
            try
            {
                //llamar procedimiento almacenado
                db.SP_CREATE_RESERVA(this.fecha_entrada, this.fecha_salida, this.firma_conformidad_cliente, this.usuario_id_usuario);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
