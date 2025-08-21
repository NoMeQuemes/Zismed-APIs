namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GuardiaTipoCuestionarioResultado")]
    public partial class GuardiaTipoCuestionarioResultado
    {
        public int GuardiaTipoCuestionarioResultadoID { get; set; }

        public int GuardiaAnamnesisID { get; set; }

        public int GuardiaTipoCuestionarioPreguntaID { get; set; }

        [StringLength(250)]
        public string Resultado { get; set; }

        public bool Anulado { get; set; }

        public virtual GuardiaAnamnesis GuardiaAnamnesis { get; set; }

        public virtual GuardiaTipoCuestionarioPregunta GuardiaTipoCuestionarioPregunta { get; set; }
    }
}
