//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PLANILLA
    {
        public int ID_PLANILLA { get; set; }
        public string CEDULA { get; set; }
        public int ID_TURNO { get; set; }
        public int ID_EMPLEADO { get; set; }
        public decimal CCSS { get; set; }
        public decimal RENTA { get; set; }
        public decimal TOTAL_CON_REBAJOS { get; set; }
        public System.DateTime FECHA { get; set; }
        public Nullable<int> AGUINALDO { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual PERSONA PERSONA { get; set; }
        public virtual TURNO TURNO { get; set; }
    }
}
