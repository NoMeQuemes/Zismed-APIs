namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GuardiaRegistro")]
    public partial class GuardiaRegistro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GuardiaRegistro()
        {
            Anaemnesis_Reducida = new HashSet<Anaemnesis_Reducida>();
            Consultas_Ambulatorias = new HashSet<Consultas_Ambulatorias>();
            GuardiaAnamnesis = new HashSet<GuardiaAnamnesis>();
            GuardiaDerivacionExterna = new HashSet<GuardiaDerivacionExterna>();
            GuardiaDerivacionInterna = new HashSet<GuardiaDerivacionInterna>();
        }

        public int GuardiaRegistroID { get; set; }

        public int GuardiaSectorID { get; set; }
        public int? TipoCuracionID { get; set; }

        public int PacienteID { get; set; }

        public int GuardiaTipoIngresoID { get; set; }

        public int? TipoAltaID { get; set; }

        public int PrestadorIngresoID { get; set; }

        public int? PrestadorEgresoID { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime? FechaEgreso { get; set; }

        [StringLength(11)]
        public string UsuarioIngreso { get; set; }

        [StringLength(11)]
        public string UsuarioEgreso { get; set; }

        [StringLength(500)]
        public string AltaObservacion { get; set; }

        public DateTime FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public bool Anulado { get; set; }

        public int? InstitucionID { get; set; }
        public DateTime? Llamado { get; set; }
        [StringLength(2)]
        public string Orden { get; set; }
        public int? TipoIngresoID { get; set; }
        public int? SectorAnterior { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaAnamnesis> GuardiaAnamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaDerivacionInterna> GuardiaDerivacionInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interconsulta> Interconsulta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Anaemnesis_Reducida> Anaemnesis_Reducida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultas_Ambulatorias> Consultas_Ambulatorias { get; set; }

        public virtual GuardiaSector GuardiaSector { get; set; }

        public virtual GuardiaTipoIngreso GuardiaTipoIngreso { get; set; }

        public virtual Pacientes Pacientes { get; set; }

        public virtual Prestadores PrestadoresIngreso { get; set; }

        public virtual Prestadores PrestadoresEgreso { get; set; }

        public virtual Tipo_AltaIntenado Tipo_AltaIntenado { get; set; }

        public virtual TipoCuracion TipoCuracion { get; set; }
        
    }
}
