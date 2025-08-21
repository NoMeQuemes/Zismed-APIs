namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Numerador_HC
    {
        [Key]
        public int NumeradorID { get; set; }        

        public int PacienteID { get; set; }        

        [Required]
        [StringLength(8)]
        public string Numero { get; set; }

        public bool Anulado { get; set; }
        public int? InstitucionID { get; set; }
        //public virtual Pacientes Pacientes { get; set; }
    }
}
