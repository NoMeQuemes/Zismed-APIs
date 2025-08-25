using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Prestadores
{
    public int PrestadorId { get; set; }

    public string Matricula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int EspecialidadId { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public bool Anulado { get; set; }

    public bool? Guardia { get; set; }

    public bool? Ambulatorio { get; set; }

    public bool? Internacion { get; set; }

    public bool? TiempoAtencionReal { get; set; }

    public int? TipoGuardiaId { get; set; }

    public string? UsuarioCarga { get; set; }

    public string? UsuarioMod { get; set; }

    public string? UsuarioBaja { get; set; }

    public DateTime? UltimaMod { get; set; }

    public string? Documento { get; set; }

    public bool? EsPrestadorImagen { get; set; }

    public string? Usuario { get; set; }

    public int? PrestadorIdhc { get; set; }

    public int? UsuarioId { get; set; }

    public string? Cuil { get; set; }

    public int? InstitucionId { get; set; }

    public int? PrestadorIdoriginal { get; set; }

    public bool? Iosepddjj { get; set; }

    public DateTime? Vencimientoddjj { get; set; }

    public bool? OrdenAtencionTurno { get; set; }

    public bool? VinculacionJardin { get; set; }

    public string? DniJardin { get; set; }

    public int? IdIosepddjj { get; set; }

    public virtual ICollection<Anamnesis> Anamnesis { get; set; } = new List<Anamnesis>();

    public virtual ICollection<AsistenciaMedicos> AsistenciaMedicos { get; set; } = new List<AsistenciaMedicos>();

    public virtual ICollection<CirujiaDetalle> CirujiaDetalle { get; set; } = new List<CirujiaDetalle>();

    public virtual ICollection<Epicrisis> Epicrisis { get; set; } = new List<Epicrisis>();

    public virtual Especialidades Especialidad { get; set; } = null!;

    public virtual ICollection<Evolucion> Evolucion { get; set; } = new List<Evolucion>();

    public virtual ICollection<GuardiaAnamnesis> GuardiaAnamnesis { get; set; } = new List<GuardiaAnamnesis>();

    public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; } = new List<GuardiaDerivacionExterna>();

    public virtual ICollection<GuardiaDerivacionInterna> GuardiaDerivacionInterna { get; set; } = new List<GuardiaDerivacionInterna>();

    public virtual ICollection<GuardiaRegistro> GuardiaRegistroPrestadorEgreso { get; set; } = new List<GuardiaRegistro>();

    public virtual ICollection<GuardiaRegistro> GuardiaRegistroPrestadorIngreso { get; set; } = new List<GuardiaRegistro>();

    public virtual ICollection<ImagenRegistro> ImagenRegistroPrestadorRealizaNavigation { get; set; } = new List<ImagenRegistro>();

    public virtual ICollection<ImagenRegistro> ImagenRegistroPrestadorSolicitaNavigation { get; set; } = new List<ImagenRegistro>();

    public virtual ICollection<IndicacionesDieta> IndicacionesDieta { get; set; } = new List<IndicacionesDieta>();

    public virtual ICollection<IndicacionesKinesiologia> IndicacionesKinesiologia { get; set; } = new List<IndicacionesKinesiologia>();

    public virtual ICollection<IndicacionesObservacionesGrales> IndicacionesObservacionesGrales { get; set; } = new List<IndicacionesObservacionesGrales>();

    public virtual ICollection<IndicacionesPosicion> IndicacionesPosicion { get; set; } = new List<IndicacionesPosicion>();

    public virtual ICollection<IndicacionesVentilacionMecanica> IndicacionesVentilacionMecanica { get; set; } = new List<IndicacionesVentilacionMecanica>();

    public virtual ICollection<Interconsulta> Interconsulta { get; set; } = new List<Interconsulta>();

    public virtual ICollection<Internaciones> InternacionesPrestadorAlta { get; set; } = new List<Internaciones>();

    public virtual ICollection<Internaciones> InternacionesPrestadorIngreso { get; set; } = new List<Internaciones>();

    public virtual ICollection<LaboratorioRegistro> LaboratorioRegistroPrestadorRealizaNavigation { get; set; } = new List<LaboratorioRegistro>();

    public virtual ICollection<LaboratorioRegistro> LaboratorioRegistroPrestadorSolicitaNavigation { get; set; } = new List<LaboratorioRegistro>();

    public virtual ICollection<MedicacionDiscreta> MedicacionDiscretaPrestadorIdindicaNavigation { get; set; } = new List<MedicacionDiscreta>();

    public virtual ICollection<MedicacionDiscreta> MedicacionDiscretaPrestadorIdretiraNavigation { get; set; } = new List<MedicacionDiscreta>();

    public virtual ICollection<MedicacionInfusionContinua> MedicacionInfusionContinuaPrestadorIdindicaNavigation { get; set; } = new List<MedicacionInfusionContinua>();

    public virtual ICollection<MedicacionInfusionContinua> MedicacionInfusionContinuaPrestadorIdretiraNavigation { get; set; } = new List<MedicacionInfusionContinua>();

    public virtual ICollection<MedicacionPaciente> MedicacionPacientePrestadorPrescribe { get; set; } = new List<MedicacionPaciente>();

    public virtual ICollection<MedicacionPaciente> MedicacionPacientePrestadorRetira { get; set; } = new List<MedicacionPaciente>();

    public virtual ICollection<MovimientosInternaciones> MovimientosInternaciones { get; set; } = new List<MovimientosInternaciones>();

    public virtual ICollection<PlanillaControl> PlanillaControl { get; set; } = new List<PlanillaControl>();

    public virtual ICollection<PlanillaTurnos> PlanillaTurnos { get; set; } = new List<PlanillaTurnos>();

    public virtual ICollection<Prescripcion> Prescripcion { get; set; } = new List<Prescripcion>();

    public virtual ICollection<PrestadorDias> PrestadorDias { get; set; } = new List<PrestadorDias>();

    public virtual ICollection<PrestadoresServicios> PrestadoresServicios { get; set; } = new List<PrestadoresServicios>();

    public virtual ICollection<ShockRoomAnamnesis> ShockRoomAnamnesis { get; set; } = new List<ShockRoomAnamnesis>();

    public virtual ICollection<ShockRoomRegistro> ShockRoomRegistro { get; set; } = new List<ShockRoomRegistro>();

    public virtual TipoGuardia? TipoGuardia { get; set; }

    public virtual ICollection<Turnos> Turnos { get; set; } = new List<Turnos>();

    public virtual ICollection<TurnosQuirofano> TurnosQuirofano { get; set; } = new List<TurnosQuirofano>();
}
