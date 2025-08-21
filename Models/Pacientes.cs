namespace WebHospital.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Futronic.SDKHelper;

    public partial class Pacientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacientes()
        {
            Anamnesis = new HashSet<Anamnesis>();
            Consultas_Ambulatorias = new HashSet<Consultas_Ambulatorias>();
            Derivaciones_Envios = new HashSet<Derivaciones_Envios>();
            Internaciones = new HashSet<Internaciones>();
            Turnos = new HashSet<Turnos>();
            Numerador_HC = new HashSet<Numerador_HC>();
            ShockRoom_Anamnesis = new HashSet<ShockRoom_Anamnesis>();
            ShockRoom_Registro = new HashSet<ShockRoom_Registro>();
            GuardiaRegistro = new HashSet<GuardiaRegistro>();

            //---
            Indicaciones_Dieta = new HashSet<Indicaciones_Dieta>();
            Indicaciones_Kinesiologia = new HashSet<Indicaciones_Kinesiologia>();
            Indicaciones_ObservacionesGrales = new HashSet<Indicaciones_ObservacionesGrales>();
            Indicaciones_Posicion = new HashSet<Indicaciones_Posicion>();
            Indicaciones_VentilacionMecanica = new HashSet<Indicaciones_VentilacionMecanica>();

            OrientacionObstetrica = new HashSet<OrientacionObstetrica>();

            MedicacionPaciente = new HashSet<MedicacionPaciente>();

            FarmaciaEgreso = new HashSet<FarmaciaEgreso>();

            Vacunas_Pacientes = new HashSet<Vacunas_Pacientes>();

            PrescripcionEncabezado = new HashSet<PrescripcionEncabezado>();

            PacienteEstado = new HashSet<PacienteEstado>();

            Turnos_Quirofano = new HashSet<Turnos_Quirofano>();


        }

        [Key]
        [UIHint("Pacientes")]
        public int PacienteID { get; set; }

        [StringLength(11)]
        public string Cuil { get; set; }

        [Display(Name = "Tipo Documento")]
        public int IdTipoDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string Documento { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        [Display(Name = "Obra Social")]
        public int? ObraSocialID { get; set; }

        [Display(Name = "Nacionalidad")]
        public int? IdNacionalidad { get; set; }

        [Display(Name = "Sexo")]
        public byte? IdSexo { get; set; }

        [Display(Name = "Genero")]
        public byte? IdSexoGenero { get; set; }

        [Display(Name = "Estado Civil")]
        public int IdEstadoCivil { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Nac.")]
        public DateTime? FechadeNacimiento { get; set; }

        [Display(Name = "Tipo Doc. Ref.")]
        public int? IdTipo_DocReferencia { get; set; }

        [StringLength(10)]
        [Display(Name = "Doc. Ref.")]
        public string Doc_Referencia { get; set; }

        [StringLength(100)]
        [Display(Name = "Residencia")]
        public string Residencia_Localidad { get; set; }

        [Display(Name = "Instrucción")]
        public int? TipoInstruccionID { get; set; }

        [Display(Name = "Laboral")]
        public int? TipoLaboralID { get; set; }

        [Display(Name = "Hijo")]
        public bool? ConDatodeMadre { get; set; }
        public string Barrio { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string RNNroFicha { get; set; }

        [StringLength(11)]
        public string UsuarioCarga { get; set; }

        public DateTime? FechaCarga { get; set; }

        public DateTime? FechaConsulPuco { get; set; }

        public bool ConsultaPuco { get; set; }

        public int? PacienteIDRef { get; set; }

        public bool Anulado { get; set; }

        public bool Unificado { get; set; }

        [Display(Name = "Localidad")]
        public int? IdLocalidad { get; set; }

        [StringLength(11)]
        public string UsuarioMod { get; set; }

        public DateTime? UltimaMod { get; set; }

        public string NroAfiliado { get; set; }

        public int? TipoParentezcoID { get; set; }

        public int? TipoBeneficiarioID { get; set; }

        public string FotoDniFrente { get; set; }

        public string FotoDniDorso { get; set; }

        public bool? RecienNacidoHospital { get; set; }
        public int? PacienteIDHC { get; set; }
        public int? CProvinciaID { get; set; }
        public int? CDepartamentoID { get; set; }
        public int? CLocalidadID { get; set; }
        public string Correo { get; set; }

        public bool? VerificadoTotem { get; set; }

        public string Ejemplar { get; set; }

        public string NumTramite { get; set; }
        public string CodigoPedidosWeb { get; set; }    

        public string Alias { get; set; }

        public int? IdMPI { get; set; }
        public string DatosAdicionales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Anamnesis> Anamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultas_Ambulatorias> Consultas_Ambulatorias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Derivaciones_Envios> Derivaciones_Envios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FarmaciaEgreso> FarmaciaEgreso { get; set; }

        public virtual EstadoCivil EstadoCivil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Internaciones> Internaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Numerador_HC> Numerador_HC { get; set; }
        public virtual ObraSocial ObraSocial { get; set; }

        public virtual Paises Paises { get; set; }

        public virtual Sexo Sexo { get; set; }

        public virtual Sexo Sexo1 { get; set; }

        public virtual Tipo_Documento Tipo_Documento { get; set; }

        public virtual Tipo_Documento Tipo_Documento1 { get; set; }

        public virtual Tipo_Instruccion Tipo_Instruccion { get; set; }

        public virtual Tipo_Laboral Tipo_Laboral { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turnos> Turnos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShockRoom_Anamnesis> ShockRoom_Anamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShockRoom_Registro> ShockRoom_Registro { get; set; }

        //----
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indicaciones_Dieta> Indicaciones_Dieta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indicaciones_Kinesiologia> Indicaciones_Kinesiologia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indicaciones_ObservacionesGrales> Indicaciones_ObservacionesGrales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indicaciones_Posicion> Indicaciones_Posicion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indicaciones_VentilacionMecanica> Indicaciones_VentilacionMecanica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrientacionObstetrica> OrientacionObstetrica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaRegistro> GuardiaRegistro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacunas_Pacientes> Vacunas_Pacientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescripcionEncabezado> PrescripcionEncabezado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PacienteEstado> PacienteEstado { get; set; }

        public virtual Pacientes PacienteReferencia { get; set; }

        public virtual Localidades Localidades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turnos_Quirofano> Turnos_Quirofano { get; set; }


    }
}
