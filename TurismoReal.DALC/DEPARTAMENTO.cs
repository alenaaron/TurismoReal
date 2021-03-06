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
    
    public partial class DEPARTAMENTO
    {
        public DEPARTAMENTO()
        {
            this.DETALLE_IMPUESTO = new HashSet<DETALLE_IMPUESTO>();
            this.DETALLE_INVENTARIO = new HashSet<DETALLE_INVENTARIO>();
            this.DETALLE_MANTENCION = new HashSet<DETALLE_MANTENCION>();
            this.DETALLE_RESERVA = new HashSet<DETALLE_RESERVA>();
        }
    
        public decimal ID_DEPARTAMENTO { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<decimal> COSTO_DEPARTAMENTO { get; set; }
        public string ESTADO_DEPARTAMENTO { get; set; }
        public string DESCRIPCION_ESTADO_DEPARTAMENTO { get; set; }
        public string ORIENTACION_DEPARTAMENTO { get; set; }
        public string ESTACIONAMIENTO { get; set; }
        public Nullable<decimal> NUM_HABITACIONES { get; set; }
        public Nullable<decimal> NUM_BAÑO { get; set; }
        public Nullable<decimal> NUM_ESTACIONAMIENTO { get; set; }
        public decimal COMUNA_ID_COMUNA { get; set; }
        public decimal COMUNA_PROVINCIA_ID_PROVINCIA { get; set; }
        public decimal COMUNA_PROVINCIA_REGION_ID_REGION { get; set; }
    
        public virtual COMUNA COMUNA { get; set; }
        public virtual ICollection<DETALLE_IMPUESTO> DETALLE_IMPUESTO { get; set; }
        public virtual ICollection<DETALLE_INVENTARIO> DETALLE_INVENTARIO { get; set; }
        public virtual ICollection<DETALLE_MANTENCION> DETALLE_MANTENCION { get; set; }
        public virtual ICollection<DETALLE_RESERVA> DETALLE_RESERVA { get; set; }
    }
}
