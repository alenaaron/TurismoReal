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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.DETALLE_ACOMPAÑANTE = new HashSet<DETALLE_ACOMPAÑANTE>();
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public string RUT_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string EMAIL { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public decimal CUENTA_USUARIO_ID_CUENTA_USUARIO { get; set; }
    
        public virtual CUENTA_USUARIO CUENTA_USUARIO { get; set; }
        public virtual ICollection<DETALLE_ACOMPAÑANTE> DETALLE_ACOMPAÑANTE { get; set; }
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}
