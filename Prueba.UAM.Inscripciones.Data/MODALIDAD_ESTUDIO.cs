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
    
    public partial class MODALIDAD_ESTUDIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MODALIDAD_ESTUDIO()
        {
            this.INSCRIPCION_ASPIRANTE = new HashSet<INSCRIPCION_ASPIRANTE>();
        }
    
        public int ID { get; set; }
        public string MODALIDAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCRIPCION_ASPIRANTE> INSCRIPCION_ASPIRANTE { get; set; }
    }
}
