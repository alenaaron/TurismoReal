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
    
    public partial class DETALLE_CHECKOUT
    {
        public decimal ID_DETALLE_CHECKOUT { get; set; }
        public Nullable<decimal> RESERVA_ID_RESERVA { get; set; }
        public Nullable<decimal> CHECK_OUT_ID_CHECK_OUT { get; set; }
    
        public virtual CHECK_OUT CHECK_OUT { get; set; }
        public virtual RESERVA RESERVA { get; set; }
    }
}
