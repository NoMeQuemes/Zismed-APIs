namespace WebHospital.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicacionPacienteHistorico")]
    public partial class MedicacionPacienteHistorico
    {
        public int MedicacionPacienteHistoricoID { get; set; }

        public int MedicacionPacienteID { get; set; }

        [Required]
        [StringLength(80)]
        public string Accion { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(11)]
        public string Usuario { get; set; }

        public bool Anulado { get; set; }

        public virtual MedicacionPaciente MedicacionPaciente { get; set; }
    }
}
