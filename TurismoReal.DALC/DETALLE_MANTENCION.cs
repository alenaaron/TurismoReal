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
    
    public partial class DETALLE_MANTENCION
    {
        public decimal ID_DETALLE_MANTENCION { get; set; }
        public decimal MANTENCION_ID_MANTENCION { get; set; }
        public decimal DEPARTAMENTO_ID_DEPARTAMENTO { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        public virtual MANTENCION MANTENCION { get; set; }
    }
}