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
    
    public partial class TIPO_TELEFONO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_TELEFONO()
        {
            this.TELEFONO = new HashSet<TELEFONO>();
        }
    
        public int ID_TELEFONO { get; set; }
        public string DESCRIPCION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELEFONO> TELEFONO { get; set; }
    }
}