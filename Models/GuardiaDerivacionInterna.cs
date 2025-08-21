namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GuardiaDerivacionInterna")]
    public partial class GuardiaDerivacionInterna
    {
        public int GuardiaDerivacionInternaID { get; set; }

        public int GuardiaRegistroID { get; set; }

        public int? GuardiaSectorDesdeID { get; set; }

        public int? ConsultorioDesdeID { get; set; }

        public int? GuardiaSectorHastaID { get; set; }

        public int? GuardiaCamaID { get; set; }

        [Display(Name = "Prestador")]
        public int PrestadorID { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(11)]
        public string Usuario { get; set; }

        public DateTime FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public bool Anulado { get; set; }

        public virtual GuardiaRegistro GuardiaRegistro { get; set; }

        public virtual GuardiaSector GuardiaSectorDesde { get; set; }

        public virtual GuardiaSector GuardiaSectorHasta { get; set; }

        public virtual Prestadores Prestadores { get; set; }

        public virtual GuardiaCama GuardiaCama { get; set; }
    }
}
