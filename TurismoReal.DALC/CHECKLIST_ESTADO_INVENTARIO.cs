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
    
    public partial class CHECKLIST_ESTADO_INVENTARIO
    {
        public decimal ID_CHECK_LIST { get; set; }
        public string ESTADO_CHECK_LIST { get; set; }
        public decimal OBJETO_HABITACION_ID_OBJETO_HABITACION { get; set; }
    
        public virtual OBJETO_HABITACION OBJETO_HABITACION { get; set; }
    }
}
