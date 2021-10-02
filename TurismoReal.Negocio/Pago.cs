using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Negocio
{
    public class Pago
    {
        public decimal id_pago { get; set; }
        public string forma_pago { get; set; }
        public decimal monto_pago { get; set; }
        public DateTime fecha_pago { get; set; }
        public decimal estado_pago_id_estado_pago { get; set; }
        public decimal reserva_id_reserva { get; set; }

        public EstadoPago EstadoPago { get; set; }
        public Reserva Reserva { get; set; }
    }
}
