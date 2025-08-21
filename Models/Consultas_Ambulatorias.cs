namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Consultas_Ambulatorias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Consultas_Ambulatorias()
        {
            Pedidos_EnConsultorio = new HashSet<Pedidos_EnConsultorio>();
            MedicacionPaciente = new HashSet<MedicacionPaciente>();
            
        }

        [Key]
        public int ConsultaID { get; set; }

        public int PacienteID { get; set; }
        public int? TurnoID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public int PrestadorID { get; set; }

        public int? ServicioId { get; set; }

        [UIHint("DropDownList")]
        public int DiagnosticoPrincipalID { get; set; }

        public int DiagnosticoSecundarioID { get; set; }

        public string Evolucion { get; set; }

        public bool Anulado { get; set; }

        public int? ObraSocialID { get; set; }

        [StringLength(256)]
        public string Presuntivo { get; set; }
        public int? InterconsultaID { get; set; }
        public int? CamaId { get; set; }
        public int? GuardiaRegistroID { get; set; }
        public int? GuardiaSectorID { get; set; }

        [StringLength(11)]
        public string UsuarioAnula { get; set; }
        public DateTime? FechaAnula { get; set; }

        [StringLength(11)]
        public string UsuarioCrea { get; set; }

        [StringLength(300)]
        public string MotivoAnula { get; set; }
        public DateTime? FechaCrea { get; set; }

        public string Prescripcion { get; set; }

        public bool Visible { get; set; }

        public int? InstitucionID { get; set; }
        public string Indicacion { get; set; }
        public bool? Psiquiatrico { get; set; }
        public int? DiagnosticoSnomed { get; set; }
        public string Informe { get; set; }

        public string DiagnosticoPrincipalVar { get; set; }

        [NotMapped] // Esto indica que no se mapeará a la base de datos
        public List<Diagnosticos_Consultas> DiagnosticosList { get; set; } = new List<Diagnosticos_Consultas>();

        public virtual GuardiaRegistro GuardiaRegistro { get; set; }
        public virtual GuardiaSector GuardiaSector { get; set; }
        public virtual Pacientes Pacientes { get; set; }
        public virtual Prestadores Prestadores { get; set; }
        public virtual Diagnosticos_Consultas Diagnosticos_Consultas { get; set; }
        public virtual Diagnosticos_Consultas Diagnosticos_Consultas1 { get; set; }
        public virtual ObraSocial ObraSocial { get; set; }
        public virtual Interconsulta Interconsulta { get; set; }
        public virtual Camas Camas { get; set; }

        public virtual Servicios Servicios { get; set; }
        public virtual Instituciones Instituciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidos_EnConsultorio> Pedidos_EnConsultorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odontograma> Odontograma { get; set; }
    }
}
