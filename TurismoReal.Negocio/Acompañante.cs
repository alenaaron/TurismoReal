using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.DALC;

namespace TurismoReal.Negocio
{
    public class Acompañante
    {

        public decimal id_acompañante { get; set; }
        public string nombre_acompañante { get; set; }
        public string apellido_acompañante { get; set; }
        public string rango_etario { get; set; }

        TurismoRealWebEntities db = new TurismoRealWebEntities();

        public List<Acompañante> ReadAll()
        {
            return this.db.ACOMPAÑANTE.Select(a => new Acompañante()
            {
                id_acompañante = a.ID_ACOMPAÑANTE,
                nombre_acompañante = a.NOMBRE_ACOMPAÑANTE,
                apellido_acompañante = a.APELLIDO_ACOMPAÑANTE,
                rango_etario = a.RANGO_ETARIO


            }).ToList();
        }
    }

}
