//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurismoReal.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOUR
    {
        public TOUR()
        {
            this.DETALLE_TOUR = new HashSet<DETALLE_TOUR>();
        }
    
        public decimal ID_TOUR { get; set; }
        public string NOMBRE_TOUR { get; set; }
        public Nullable<System.DateTime> FECHA_TOUR { get; set; }
        public Nullable<decimal> COSTO_TOUR { get; set; }
        public string DESCRIPCION_TOUR { get; set; }
    
        public virtual ICollection<DETALLE_TOUR> DETALLE_TOUR { get; set; }
    }
}
