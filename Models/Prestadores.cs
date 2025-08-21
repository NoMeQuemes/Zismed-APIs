namespace Zismed_Apis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Prestadores
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prestadores()
        {
            Anamnesis = new HashSet<Anamnesis>();
            Derivaciones_Envios = new HashSet<Derivaciones_Envios>();
            Internaciones = new HashSet<Internaciones>();
            Internaciones1 = new HashSet<Internaciones>();
            Movimientos_Internaciones = new HashSet<Movimientos_Internaciones>();
            Planilla_Turnos = new HashSet<Planilla_Turnos>();
            PrestadoresServicios = new HashSet<PrestadoresServicios>();
            PrestadorDias = new HashSet<PrestadorDias>();
            Servicios = new HashSet<Servicios>();
            Turnos = new HashSet<Turnos>();
            ShockRoom_Anamnesis = new HashSet<ShockRoom_Anamnesis>();
            ShockRoom_Registro = new HashSet<ShockRoom_Registro>();
            LaboratorioRegistroSol = new HashSet<LaboratorioRegistro>();
            LaboratorioRegistrosRea = new HashSet<LaboratorioRegistro>();
            ImagenRegistroSol = new HashSet<ImagenRegistro>();
            ImagenRegistrosRea = new HashSet<ImagenRegistro>();
            GuardiaDerivacionExterna = new HashSet<GuardiaDerivacionExterna>();
            GuardiaDerivacionInterna = new HashSet<GuardiaDerivacionInterna>();
            GuardiaRegistroIngreso = new HashSet<GuardiaRegistro>();
            GuardiaRegistroEgreso = new HashSet<GuardiaRegistro>();

            //---
            Indicaciones_Dieta = new HashSet<Indicaciones_Dieta>();
            Indicaciones_Kinesiologia = new HashSet<Indicaciones_Kinesiologia>();
            Indicaciones_ObservacionesGrales = new HashSet<Indicaciones_ObservacionesGrales>();
            Indicaciones_Posicion = new HashSet<Indicaciones_Posicion>();
            Indicaciones_VentilacionMecanica = new HashSet<Indicaciones_VentilacionMecanica>();

            MedicacionInfusionContinuaIndica = new HashSet<MedicacionInfusionContinua>();
            MedicacionInfusionContinuaRetira = new HashSet<MedicacionInfusionContinua>();
            MedicacionDiscretaIndica = new HashSet<MedicacionDiscreta>();
            MedicacionDiscretaRetira = new HashSet<MedicacionDiscreta>();
            //---

            // PrestadoresGuardia = new HashSet<PrestadoresGuardia>();

            MedicacionPaciente = new HashSet<MedicacionPaciente>();
            MedicacionPaciente1 = new HashSet<MedicacionPaciente>();

            Evolucion = new HashSet<Evolucion>();
            Epicrisis = new HashSet<Epicrisis>();

            CirujiaDetalle = new HashSet<CirujiaDetalle>();
            PrestadoresEspecialidades = new HashSet<PrestadoresEspecialidades>();
            Turnos_Quirofano = new HashSet<Turnos_Quirofano>();

        }

        [Key]
        public int PrestadorID { get; set; }

        [Required]
        [StringLength(10)]
        public string Matricula { get; set; }
        [Required]
        [StringLength(10)]
        public string Documento { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public int EspecialidadID { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool Anulado { get; set; }

        public bool? Guardia { get; set; }

        public bool? Ambulatorio { get; set; }

        public bool? Internacion { get; set; }

        public bool? TiempoAtencionReal { get; set; }

        public int? TipoGuardiaID { get; set; }
        [StringLength(11)]
        public string UsuarioCarga { get; set; }
        [StringLength(11)]
        public string UsuarioMod { get; set; }
        [StringLength(11)]
        public string UsuarioBaja { get; set; }

        public DateTime? UltimaMod { get; set; }

        public bool EsPrestadorImagen { get; set; }

        public int? InstitucionID { get; set; }

        public int? UsuarioID { get; set; }
        public string Usuario { get; set; }
        public int? PrestadorIDHC { get; set; }
        public string Cuil { get; set; }
        public bool? IOSEPddjj { get; set; }
        public DateTime? Vencimientoddjj { get; set; }
        public virtual TipoGuardia TipoGuardia { get; set; }
        public int? idIOSEPddjj { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Anamnesis> Anamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Derivaciones_Envios> Derivaciones_Envios { get; set; }

        public virtual Especialidades Especialidades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Internaciones> Internaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Internaciones> Internaciones1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimientos_Internaciones> Movimientos_Internaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Planilla_Turnos> Planilla_Turnos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrestadoresServicios> PrestadoresServicios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turnos> Turnos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrestadorDias> PrestadorDias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicios> Servicios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interconsulta> Interconsulta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShockRoom_Anamnesis> ShockRoom_Anamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShockRoom_Registro> ShockRoom_Registro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LaboratorioRegistro> LaboratorioRegistroSol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LaboratorioRegistro> LaboratorioRegistrosRea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagenRegistro> ImagenRegistroSol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagenRegistro> ImagenRegistrosRea { get; set; }

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


        //----
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionDiscreta> MedicacionDiscretaIndica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionDiscreta> MedicacionDiscretaRetira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionInfusionContinua> MedicacionInfusionContinuaIndica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionInfusionContinua> MedicacionInfusionContinuaRetira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaDerivacionInterna> GuardiaDerivacionInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaRegistro> GuardiaRegistroIngreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaRegistro> GuardiaRegistroEgreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GuardiaAnamnesis> GuardiaAnamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultas_Ambulatorias> Consultas_Ambulatorias { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PrestadoresGuardia> PrestadoresGuardia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicacionPaciente> MedicacionPaciente1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evolucion> Evolucion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Epicrisis> Epicrisis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CirujiaDetalle> CirujiaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrestadoresEspecialidades> PrestadoresEspecialidades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turnos_Quirofano> Turnos_Quirofano { get; set; }

    }
}
