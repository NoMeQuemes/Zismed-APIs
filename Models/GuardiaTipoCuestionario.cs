namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GuardiaTipoCuestionario")]
    public partial class GuardiaTipoCuestionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GuardiaTipoCuestionario()
        {
            GuardiaAnamnesis = new HashSet<GuardiaAnamnesis>();
            GuardiaTipoCuestionarioPregunta = new HashSet<GuardiaTipoCuestionarioPregunta>();
            GuardiaTipoCuestionarioXSector = new HashSet<GuardiaTipoCuestionarioXSector>();
        }

        public int GuardiaTipoCuestionarioID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public bool Anulado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaAnamnesis> GuardiaAnamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaTipoCuestionarioPregunta> GuardiaTipoCuestionarioPregunta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaTipoCuestionarioXSector> GuardiaTipoCuestionarioXSector { get; set; }
    }
}
