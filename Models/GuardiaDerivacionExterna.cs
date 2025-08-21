namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GuardiaDerivacionExterna")]
    public partial class GuardiaDerivacionExterna
    {
        public int GuardiaDerivacionExternaID { get; set; }

        public int GuardiaRegistroID { get; set; }

        public int GuardiaSectorID { get; set; }

        public int PrestadorID { get; set; }

        public int? SectorInternadoID { get; set; }

        public int? ServicioID { get; set; }

        public int? CentroID { get; set; }

        public int? MovilID { get; set; }

        [StringLength(500)]
        public string Motivo { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(100)]
        public string OtroMedioTraslado { get; set; }

        [StringLength(11)]
        public string Usuario { get; set; }

        public DateTime FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public bool Anulado { get; set; }

        [StringLength(100)]
        public string OtroCentro { get; set; }

        [StringLength(500)]
        public string EstudiosComp { get; set; }

        [StringLength(500)]
        public string MedicacionSum { get; set; }
        
        [StringLength(500)]
        public string Antecedentes { get; set; }

        public virtual Centro Centro { get; set; }

        public virtual GuardiaRegistro GuardiaRegistro { get; set; }

        public virtual GuardiaSector GuardiaSector { get; set; }

        public virtual Habitaciones_Hospital Habitaciones_Hospital { get; set; }

        public virtual Prestadores Prestadores { get; set; }

        public virtual Servicios Servicios { get; set; }

        public virtual MovilHospital MovilHospital { get; set; }
    }
}
