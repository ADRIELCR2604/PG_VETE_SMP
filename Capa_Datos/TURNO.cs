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
    
    public partial class TURNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TURNO()
        {
            this.PLANILLA = new HashSet<PLANILLA>();
            this.REPORTE_HISTORIAL = new HashSet<REPORTE_HISTORIAL>();
        }
    
        public int ID_TURNO { get; set; }
        public string DESCRIPCION { get; set; }
        public System.TimeSpan HORA_ENTRADA { get; set; }
        public System.TimeSpan HORA_SALIDA { get; set; }
        public int ID_PUESTO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLANILLA> PLANILLA { get; set; }
        public virtual PUESTO PUESTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTE_HISTORIAL> REPORTE_HISTORIAL { get; set; }
    }
}
