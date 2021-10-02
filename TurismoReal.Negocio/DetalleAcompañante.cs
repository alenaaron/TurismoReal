using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Negocio
{
    public class DetalleAcompañante
    {
        public decimal id_detalle_acompañante { get; set; }
        public decimal acompañante_id_acompañante { get; set; }
        public decimal usuario_rut_usuario { get; set; }

        public Acompañante Acompañante { get; set; }
        public Usuario Usuario { get; set; }
    }
}
