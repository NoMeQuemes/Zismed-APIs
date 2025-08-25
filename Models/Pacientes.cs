using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Pacientes
{
    public int PacienteId { get; set; }

    public string? Cuil { get; set; }

    public int IdTipoDocumento { get; set; }

    public string Documento { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public int? ObraSocialId { get; set; }

    public int? IdNacionalidad { get; set; }

    public byte? IdSexo { get; set; }

    public byte? IdSexoGenero { get; set; }

    public int? IdEstadoCivil { get; set; }

    public DateOnly? FechadeNacimiento { get; set; }

    public int? IdTipoDocReferencia { get; set; }

    public string? DocReferencia { get; set; }

    public string? ResidenciaLocalidad { get; set; }

    public string? Barrio { get; set; }

    public string? Localidad { get; set; }

    public int? TipoInstruccionId { get; set; }

    public int? TipoLaboralId { get; set; }

    public bool? ConDatodeMadre { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaCarga { get; set; }

    public string? Telefono { get; set; }

    public string? RnnroFicha { get; set; }

    public int? PacienteIdref { get; set; }

    public string? UsuarioCarga { get; set; }

    public bool Unificado { get; set; }

    public int? IdLocalidad { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? UltimaMod { get; set; }

    public string? NroAfiliado { get; set; }

    public int? TipoBeneficiarioId { get; set; }

    public int? TipoParentezcoId { get; set; }

    public string? FotoDniFrente { get; set; }

    public string? FotoDniDorso { get; set; }

    public DateTime? FechaConsulPuco { get; set; }

    public bool? ConsultaPuco { get; set; }

    public bool? RecienNacidoHospital { get; set; }

    public int? PacienteIdhc { get; set; }

    public int? PacienteIdoriginal { get; set; }

    public bool? Covid19 { get; set; }

    public int? CprovinciaId { get; set; }

    public int? CdepartamentoId { get; set; }

    public int? ClocalidadId { get; set; }

    public string? Correo { get; set; }

    public int? ProfesionId { get; set; }

    public bool? Considerar { get; set; }

    public bool? VinculadoJardin { get; set; }

    public bool? VerificadoTotem { get; set; }

    public string? Ejemplar { get; set; }

    public string? NumTramite { get; set; }

    public int? IdBarrio { get; set; }

    public string? CodigoPedidosWeb { get; set; }

    public DateTime? CreadoPorWpp { get; set; }

    public bool? ValidadoPorWpp { get; set; }

    public string? Alias { get; set; }

    public int? IdMpi { get; set; }

    public string? DatosAdicionales { get; set; }

    public virtual ICollection<Anamnesis> Anamnesis { get; set; } = new List<Anamnesis>();

    public virtual ICollection<DerivacionesEnvios> DerivacionesEnvios { get; set; } = new List<DerivacionesEnvios>();

    public virtual ICollection<GrupoFamiliar> GrupoFamiliar { get; set; } = new List<GrupoFamiliar>();
    [JsonIgnore]

    public virtual ICollection<GuardiaRegistro> GuardiaRegistro { get; set; } = new List<GuardiaRegistro>();

    public virtual ICollection<ImagenRegistro> ImagenRegistro { get; set; } = new List<ImagenRegistro>();

    public virtual ICollection<IndicacionesDieta> IndicacionesDieta { get; set; } = new List<IndicacionesDieta>();

    public virtual ICollection<IndicacionesKinesiologia> IndicacionesKinesiologia { get; set; } = new List<IndicacionesKinesiologia>();

    public virtual ICollection<IndicacionesObservacionesGrales> IndicacionesObservacionesGrales { get; set; } = new List<IndicacionesObservacionesGrales>();

    public virtual ICollection<IndicacionesPosicion> IndicacionesPosicion { get; set; } = new List<IndicacionesPosicion>();

    public virtual ICollection<IndicacionesVentilacionMecanica> IndicacionesVentilacionMecanica { get; set; } = new List<IndicacionesVentilacionMecanica>();

    public virtual ICollection<InternacionAcompanantes> InternacionAcompanantes { get; set; } = new List<InternacionAcompanantes>();

    public virtual ICollection<Internaciones> Internaciones { get; set; } = new List<Internaciones>();

    public virtual ICollection<Pacientes> InversePacienteIdrefNavigation { get; set; } = new List<Pacientes>();

    public virtual ICollection<MedicacionDiscreta> MedicacionDiscreta { get; set; } = new List<MedicacionDiscreta>();

    public virtual ICollection<MedicacionInfusionContinua> MedicacionInfusionContinua { get; set; } = new List<MedicacionInfusionContinua>();

    public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; } = new List<MedicacionPaciente>();

    public virtual ICollection<NotificacionCovidResidencia> NotificacionCovidResidencia { get; set; } = new List<NotificacionCovidResidencia>();

    public virtual ICollection<NotificacionDengue> NotificacionDengue { get; set; } = new List<NotificacionDengue>();

    public virtual ICollection<NotificacionesCovid> NotificacionesCovid { get; set; } = new List<NotificacionesCovid>();
    [JsonIgnore]
    public virtual ICollection<NumeradorHc> NumeradorHc { get; set; } = new List<NumeradorHc>();

    public virtual ICollection<Odontograma> Odontograma { get; set; } = new List<Odontograma>();

    public virtual ICollection<OrientacionObstetrica> OrientacionObstetrica { get; set; } = new List<OrientacionObstetrica>();

    public virtual PacienteEstado? PacienteEstado { get; set; }

    public virtual Pacientes? PacienteIdrefNavigation { get; set; }

    public virtual ICollection<PrescripcionEncabezado> PrescripcionEncabezado { get; set; } = new List<PrescripcionEncabezado>();

    public virtual ICollection<ShockRoomAnamnesis> ShockRoomAnamnesis { get; set; } = new List<ShockRoomAnamnesis>();

    public virtual ICollection<ShockRoomRegistro> ShockRoomRegistro { get; set; } = new List<ShockRoomRegistro>();

    public virtual ICollection<Turnos> Turnos { get; set; } = new List<Turnos>();

    public virtual ICollection<TurnosQuirofano> TurnosQuirofano { get; set; } = new List<TurnosQuirofano>();
}
