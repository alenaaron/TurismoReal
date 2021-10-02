using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Negocio
{
    public class Comuna
    {
        public decimal id_comuna { get; set; }
        public string nombre_comuna { get; set; }
        public decimal provincia_id_provincia { get; set; }
        public decimal provincia_region_id_region { get; set; }

        public Provincia Provincia { get; set; }
        public Region Region { get; set; }

    }
}
