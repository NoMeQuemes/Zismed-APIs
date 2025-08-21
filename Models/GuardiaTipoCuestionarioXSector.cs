namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GuardiaTipoCuestionarioXSector")]
    public partial class GuardiaTipoCuestionarioXSector
    {
        public int GuardiaTipoCuestionarioXSectorID { get; set; }

        public int GuardiaSectorID { get; set; }

        public int GuardiaTipoCuestionarioID { get; set; }

        public bool Anulado { get; set; }

        public virtual GuardiaSector GuardiaSector { get; set; }

        public virtual GuardiaTipoCuestionario GuardiaTipoCuestionario { get; set; }
    }
}
