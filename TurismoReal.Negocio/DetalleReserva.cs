using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Negocio
{
    public class DetalleReserva
    {
        public decimal id_detalle_reserva { get; set; }
        public decimal reserva_id_reserva { get; set; }
        public decimal departamento_id_departamento { get; set; }

        public Reserva Reserva { get; set; }
        public Departamento Departamento { get; set; }
    }
}
