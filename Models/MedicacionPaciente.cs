namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using WebHospital.Models;

    [Table("MedicacionPaciente")]
    public partial class MedicacionPaciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicacionPaciente()
        {
            MedicacionPacienteDetalle = new HashSet<MedicacionPacienteDetalle>();
            MedicacionPacienteHistorico = new HashSet<MedicacionPacienteHistorico>();
        }

        [Key]
        public int MedicacionPacienteID { get; set; }

        public int PacienteID { get; set; }

        public int PrestadorPrescribeID { get; set; }

        public int? PrestadorRetiraID { get; set; }

        public int? GuardiaRegistroID { get; set; }

        public int? GuardiaSectorID { get; set; }

        public int? InternacionID { get; set; }

        public int? SectorInternadoID { get; set; }

        public int? TurnoID { get; set; }

        public int? ServicioID { get; set; }

        public int? ConsultaID { get; set; }

        public int MedicacionViaID { get; set; }

        public int? TipoGoteoID { get; set; }

        public int? SolucionID { get; set; }

        public int TipoEstadoMedicacionID { get; set; }

        public int? EnfermeriaID { get; set; }
        public int? EmfermeroID { get; set; }

        [StringLength(20)]
        public string Tipo { get; set; }

        [StringLength(80)]
        public string Programa { get; set; }

        public int? FrecuenciaHs { get; set; }

        public int? Goteo { get; set; }

        public decimal? CantidadSolucion { get; set; }

        public DateTime FechaPrescribe { get; set; }

        public DateTime? FechaRetira { get; set; }

        public DateTime FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public DateTime? FechaProcesa { get; set; }

        public DateTime? FechaAplica { get; set; }

        [StringLength(11)]
        public string UsuarioCrea { get; set; }

        [StringLength(11)]
        public string UsuarioModifica { get; set; }

        [StringLength(11)]
        public string UsuarioProcesa { get; set; }

        [StringLength(11)]
        public string UsuarioAplica { get; set; }

        public bool Anulado { get; set; }

        public int? PrescripcionID { get; set; }

        public int? Opcion { get; set; }

        public int? InstitucionID { get; set; }
        public string Evolucion { get; set; }
        public string ObservacionAdicional { get; set; }

        public virtual GuardiaSector GuardiaSector { get; set; }

        public virtual Habitaciones_Hospital Habitaciones_Hospital { get; set; }

        public virtual MedicacionVia MedicacionVia { get; set; }

        public virtual Turnos Turno { get; set; }

        public virtual Consultas_Ambulatorias Consultas_Ambulatorias { get; set; }

        public virtual Pacientes Pacientes { get; set; }

        public virtual Prestadores Prestadores { get; set; }

        public virtual Prestadores Prestadores1 { get; set; }

        public virtual TipoEstadoMedicacionPaciente TipoEstadoMedicacionPaciente { get; set; }

        public virtual TipoGoteo TipoGoteo { get; set; }

        public virtual Emfermeros Emfermeros { get; set; }

        public virtual Instituciones Instituciones { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionPacienteDetalle> MedicacionPacienteDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionPacienteHistorico> MedicacionPacienteHistorico { get; set; }

        
    }
}
