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
    
    public partial class SELECCION
    {
        public int ID_SELECCION { get; set; }
        public int ID_CURRICULUM { get; set; }
        public bool ACTIVO { get; set; }
    
        public virtual CURRICULUM CURRICULUM { get; set; }
    }
}
