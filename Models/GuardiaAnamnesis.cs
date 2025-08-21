namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class GuardiaAnamnesis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GuardiaAnamnesis()
        {
            GuardiaTipoCuestionarioResultado = new HashSet<GuardiaTipoCuestionarioResultado>();
        }

        public int GuardiaAnamnesisID { get; set; }

        public int GuardiaRegistroID { get; set; }

        public int GuardiaSectorID { get; set; }

        public int GuardiaTipoCuestionarioID { get; set; }

        public int? PrestadorID { get; set; }

        public int? EmpleadoId { get; set; }
        public int? EmfermeroID { get; set; }

        public DateTime FechaAnamneisis { get; set; }

        public DateTime FechaCrea { get; set; }

        [StringLength(11)]
        public string Usuario { get; set; }

        public bool Anulado { get; set; }

        public virtual GuardiaRegistro GuardiaRegistro { get; set; }

        public virtual GuardiaSector GuardiaSector { get; set; }

        public virtual Prestadores Prestadores { get; set; }

        public virtual GuardiaTipoCuestionario GuardiaTipoCuestionario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaTipoCuestionarioResultado> GuardiaTipoCuestionarioResultado { get; set; }
    }
}
