namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GuardiaSector")]
    public partial class GuardiaSector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GuardiaSector()
        {
            Consultas_Ambulatorias = new HashSet<Consultas_Ambulatorias>();
            Anaemnesis_Reducida = new HashSet<Anaemnesis_Reducida>();
            GuardiaAnamnesis = new HashSet<GuardiaAnamnesis>();
            GuardiaDerivacionExterna = new HashSet<GuardiaDerivacionExterna>();
            GuardiaDerivacionInternaDesde = new HashSet<GuardiaDerivacionInterna>();
            GuardiaDerivacionInternaHasta = new HashSet<GuardiaDerivacionInterna>();
            GuardiaRegistro = new HashSet<GuardiaRegistro>();
            MedicacionPaciente = new HashSet<MedicacionPaciente>();
            GuardiaTipoCuestionarioXSector = new HashSet<GuardiaTipoCuestionarioXSector>();
        }

        public int GuardiaSectorID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        public DateTime FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public bool ConsultaMedica { get; set; }
        public bool MedicacionContinua { get; set; }
        public bool MedicacionDiscreta { get; set; }
        public bool SignosVitales { get; set; }
        public bool RegistraIngreso { get; set; }
        public bool ProcedimientoCuraciones { get; set; }
        public bool VeGrillaAtencion { get; set; }
        public bool Interconsulta { get; set; }
        public bool Laboratorio { get; set; }
        public bool Observaciones { get; set; }        
        public bool Anulado { get; set; }
        public bool AdmisionGral { get; set; }
        public bool SalidaDirecta { get; set; }
        public bool Balance { get; set; }
        public bool Imagenes { get; set; }
        public int? InstitucionID { get; set; }
        public int? TvMonitorID { get; set; }
        public bool TieneCamas { get; set; }
        public int? ConsultorioID { get; set; }
        public bool? RequiereTelefono { get; set; }
        public bool? BuscarTurnos { get; set; }
        public bool? CompletarDatos { get; set; }
        public bool? PedidoUrgente { get; set; }
        public bool? Anamnesis { get; set; }
        public bool? Consentimientos { get; set; }
        public bool? NotificacionesCovid { get; set; }
        public bool? NotificacionDengues { get; set; }
        public bool? InformeCCI { get; set; }
        public int? EdadMin { get; set; }
        public int? EdadMax { get; set; }
        public byte? SexoID { get; set; }
        public bool? EsNeo { get; set; }

        public bool? Embarazada { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaAnamnesis> GuardiaAnamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaDerivacionInterna> GuardiaDerivacionInternaDesde { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaDerivacionInterna> GuardiaDerivacionInternaHasta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaRegistro> GuardiaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaTipoCuestionarioXSector> GuardiaTipoCuestionarioXSector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Anaemnesis_Reducida> Anaemnesis_Reducida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultas_Ambulatorias> Consultas_Ambulatorias { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<GuardiaSectoresDestino> GuardiaSectoresDestinoOrigen { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<GuardiaSectoresDestino> GuardiaSectoresDestinoDestino { get; set; }
    }
}
