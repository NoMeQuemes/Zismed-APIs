namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Anaemnesis_Reducida
    {
        [Key]
        public int AnaemnesisReducidaID { get; set; }

        public int PacienteID { get; set; }

        public int? TurnoID { get; set; }

        public int? InternacionID { get; set; }

        public int? ShockRoomRegistroID { get; set; }

        public int? GuardiaRegistroID { get; set; }

        public int? GuardiaSectorID { get; set; }
        
        public decimal? Peso { get; set; }

        
        public decimal? Temperatura { get; set; }

       
        public int? Pulso { get; set; }

        [Display(Name = "Tension Arterial Maxima")]
        public int? TensionArterialMaxima { get; set; }

        [Display(Name = "Tension Arterial Minima")]
        public int? TensionArterialMinima { get; set; }

        public int? Talla { get; set; }

        public int? Frecuencia_Respiratoria { get; set; }

        public int? Frecuencia_Cardiaca { get; set; }

        public int? Edad_Gestacional { get; set; }

        public decimal? Perimetro_Cefalico { get; set; }

        public decimal? MasaCorporal { get; set; }
        public decimal? Percentil { get; set; }

        public decimal? ScoreTal { get; set; }
        public int? Glasgow { get; set; }

        public bool Anulado { get; set; }

        public DateTime? FechaCrea { get; set; }

        [StringLength(11)]
        public string Usuario { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Primera ingesta")]
        public DateTime? FechaPrimeraIngesta { get; set; }

        [StringLength(150)]
        public string AntecedentesMadre { get; set; }

        
        public int? Saturacion { get; set; }

        public int? Glucemia { get; set; }

        public int? InstitucionID { get; set; }
        public bool? Fumador { get; set; }
        public string Evolucion { get; set; }

        public int? EmfermeroID { get; set; }

        //public virtual Pacientes Pacientes { get; set; }
        //public virtual Internaciones Internaciones { get; set; }

        public virtual GuardiaRegistro GuardiaRegistro { get; set; }
        public virtual GuardiaSector GuardiaSector { get; set; }
        //public virtual Emfermeros Emfermeros { get; set; }
        //public virtual Instituciones Instituciones { get; set; }
    }
}
