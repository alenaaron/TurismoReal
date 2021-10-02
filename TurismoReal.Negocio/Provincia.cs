using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Negocio
{
    public class Provincia
    {
        public decimal  id_provincia { get; set; }
        public string nombre_provincia { get; set; }
        public decimal region_id_region { get; set; }

        public Region Region { get; set; }  
    }
}
