namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GuardiaTipoCuestionarioPregunta")]
    public partial class GuardiaTipoCuestionarioPregunta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GuardiaTipoCuestionarioPregunta()
        {
            GuardiaTipoCuestionarioLista = new HashSet<GuardiaTipoCuestionarioLista>();
            GuardiaTipoCuestionarioResultado = new HashSet<GuardiaTipoCuestionarioResultado>();
        }

        public int GuardiaTipoCuestionarioPreguntaID { get; set; }

        public int GuardiaTipoCuestionarioID { get; set; }

        public int Orden { get; set; }

        [Required]
        [StringLength(50)]
        public string Pregunta { get; set; }

        public bool Obligatorio { get; set; }

        public int CuestionarioTipoRespuestaID { get; set; }

        public decimal? ValorMaximo { get; set; }

        public decimal? ValorMinimo { get; set; }

        public bool Anulado { get; set; }

        public virtual GuardiaTipoCuestionario GuardiaTipoCuestionario { get; set; }

        public virtual CuestionarioTipoRespuesta CuestionarioTipoRespuesta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaTipoCuestionarioLista> GuardiaTipoCuestionarioLista { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaTipoCuestionarioResultado> GuardiaTipoCuestionarioResultado { get; set; }
    }
}
