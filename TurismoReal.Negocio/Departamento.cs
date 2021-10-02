using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.DALC;

namespace TurismoReal.Negocio
{
    public class Departamento
    {
        public decimal id_departamento { get; set; }
        public string direccion { get; set; }
        public decimal costo_departamento { get; set; }
        public string estado_departamento { get; set; }
        public string descripcion_estado_departamento { get; set; }
        public string orientacion_departamento { get; set; }
        public string estacionamiento { get; set; }
        public decimal num_habitaciones { get; set; }
        public decimal num_baño { get; set; }
        public decimal num_estacionamiento { get; set; }
        public decimal comuna_id_comuna { get; set; }
        public decimal comuna_provincia_id_provincia { get; set; }
        public decimal comuna_provincia_region_id_region { get; set; }

        public Comuna Comuna { get; set; }
        public Provincia Provincia { get; set; }
        public Region Region { get; set; }


        TurismoRealWebEntities db = new TurismoRealWebEntities();


        public List<Departamento> ReadAll()
        {
            return db.DEPARTAMENTO.Select(d => new Departamento()
            {
                id_departamento = d.ID_DEPARTAMENTO,
                direccion = d.DIRECCION,
                costo_departamento = (decimal)d.COSTO_DEPARTAMENTO,
                estado_departamento = d.ESTADO_DEPARTAMENTO,
                descripcion_estado_departamento = d.DESCRIPCION_ESTADO_DEPARTAMENTO,
                orientacion_departamento = d.ORIENTACION_DEPARTAMENTO,
                estacionamiento = d.ESTACIONAMIENTO,
                num_habitaciones = (decimal)d.NUM_HABITACIONES,
                num_baño = (decimal)d.NUM_BAÑO,
                num_estacionamiento = (decimal)d.NUM_ESTACIONAMIENTO,
                comuna_id_comuna = (decimal)d.COMUNA_ID_COMUNA,
                comuna_provincia_id_provincia = (decimal)d.COMUNA_PROVINCIA_ID_PROVINCIA,
                comuna_provincia_region_id_region = (decimal)d.COMUNA_PROVINCIA_REGION_ID_REGION





            }).ToList();

        }

    }

}
