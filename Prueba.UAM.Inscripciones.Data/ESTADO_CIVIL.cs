//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba.UAM.Inscripciones.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESTADO_CIVIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADO_CIVIL()
        {
            this.ASPIRANTE = new HashSet<ASPIRANTE>();
        }
    
        public int ID { get; set; }
        public string ESTADO_CIVIL1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASPIRANTE> ASPIRANTE { get; set; }
    }
}
