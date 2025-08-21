namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MedicacionPacienteDetalle")]
    public partial class MedicacionPacienteDetalle
    {
        public int MedicacionPacienteDetalleID { get; set; }

        public int MedicacionPacienteID { get; set; }

        public int? FarmaciaArticuloID { get; set; }

        public int? NuevaDro { get; set; }

        public int? MultiDro { get; set; }

        public int TipoEstadoMedicacionPacienteDetalleID { get; set; }

        [Required]
        [StringLength(100)]
        public string ArticuloNombre { get; set; }

        [StringLength(100)]
        public string ArticuloPresentacion { get; set; }

        [StringLength(100)]
        public string ArticuloDroga { get; set; }

        public decimal Cantidad { get; set; }

        public DateTime FechaCrea { get; set; }

        public DateTime? FechaRetira { get; set; }

        public DateTime? FechaModifica { get; set; }

        public DateTime? FechaAplicacion { get; set; }

        [StringLength(11)]
        public string UsuarioCrea { get; set; }

        [StringLength(11)]
        public string UsuarioModifica { get; set; }

        [StringLength(11)]
        public string UsuarioAplica { get; set; }

        public bool Anulado { get; set; }

        public string Descripcion { get; set; }
        public int? ViaTipoID { get; set; }
        public string Tipo { get; set; }
        public int? FrecuenciaHs { get; set; }
        public int? Goteo { get; set; }
        public int? TipoGoteoID { get; set; }
        public string InicioServicio { get; set; }
        public string ObservacionMedico { get; set; }
        public string ObservacionEnfermero { get; set; }
        public string ObservacionRevierte { get; set; }
        public int? EnfermeroAplicaID { get; set; }
        public bool? sinStock { get; set; }
        public string ObservacionSinStock { get; set; }
        public virtual FarmaciaArticulo FarmaciaArticulo { get; set; }

        public virtual MedicacionPaciente MedicacionPaciente { get; set; }

        public virtual TipoEstadoMedicacionPacienteDetalle TipoEstadoMedicacionPacienteDetalle { get; set; }

    }
}
