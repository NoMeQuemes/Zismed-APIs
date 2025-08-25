using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotificacionesCovid
{
    public int NotificacionId { get; set; }

    public byte TipoCaso { get; set; }

    public int InstitucionId { get; set; }

    public string EventoId { get; set; } = null!;

    public int PacienteId { get; set; }

    public bool PrivadoLibertad { get; set; }

    public bool ResAdultoMayor { get; set; }

    public bool PuebloIndigena { get; set; }

    public int EtniaId { get; set; }

    public DateOnly FechaInicioSintomas { get; set; }

    public byte SemanaEpidemFis { get; set; }

    public bool PacienteAmbulatorio { get; set; }

    public bool PacienteInternado { get; set; }

    public DateOnly FechaPrimeraConsulta { get; set; }

    public bool Fallecido { get; set; }

    public byte? LugarFallecimiento { get; set; }

    public string? OtroLugarFallecimiento { get; set; }

    public bool Anosmia { get; set; }

    public bool Disgeusia { get; set; }

    public bool FiebreMas38 { get; set; }

    public bool FiebreMenos38 { get; set; }

    public bool Tos { get; set; }

    public bool Odinofagia { get; set; }

    public bool DificultadResp { get; set; }

    public bool Cefalea { get; set; }

    public bool Mialgia { get; set; }

    public bool DiarreaVomitos { get; set; }

    public string? OtrosSintomas { get; set; }

    public bool ErupConjInf { get; set; }

    public bool HipotensionShock { get; set; }

    public bool PericardiaValvAnom { get; set; }

    public bool CoagDiarreaVomDol { get; set; }

    public bool MarcElevInflamacion { get; set; }

    public bool PresentaEnfPrevias { get; set; }

    public bool Asma { get; set; }

    public bool BajoPesoNacimiento { get; set; }

    public bool Bronquiolitis { get; set; }

    public bool Diabetes { get; set; }

    public bool Dialisis { get; set; }

    public bool Hemodialisis { get; set; }

    public bool Embarazo { get; set; }

    public bool Hepatica { get; set; }

    public bool Neurologica { get; set; }

    public bool Oncologica { get; set; }

    public bool RenalNoDialisis { get; set; }

    public bool Obesidad { get; set; }

    public bool Inmunosup { get; set; }

    public bool Epoc { get; set; }

    public bool ExFumador { get; set; }

    public bool Fumador { get; set; }

    public bool Cardiopatia { get; set; }

    public bool HiperTensionArt { get; set; }

    public bool Nac { get; set; }

    public bool Prematuridad { get; set; }

    public bool Puerperio { get; set; }

    public bool CerebroVasc { get; set; }

    public bool DialisisPeritoneal { get; set; }

    public bool TraspRenal { get; set; }

    public string? OtrasEnfPrevias { get; set; }

    public string? ObservacionesEnfPrev { get; set; }

    public bool Irag { get; set; }

    public bool Eti { get; set; }

    public bool Neumonia { get; set; }

    public string? OtrasComorb { get; set; }

    public DateOnly? LipoRitoJarabeInicio { get; set; }

    public DateOnly? LipoRitoJarabeFin { get; set; }

    public DateOnly? HidroxiclorInicio { get; set; }

    public DateOnly? HidroxiclorFin { get; set; }

    public DateOnly? LipoRitoCompInicio { get; set; }

    public DateOnly? LipoRitoCompFin { get; set; }

    public DateOnly? PlasmaInicio { get; set; }

    public DateOnly? PlasmaFin { get; set; }

    public DateOnly? AsistRespiratoriaInicio { get; set; }

    public DateOnly? AsistRespiratoriaFin { get; set; }

    public string? OtrosTratamientos { get; set; }

    public DateOnly? OtrosTratamInicio { get; set; }

    public DateOnly? OtrosTratamFin { get; set; }

    public string? InstitucionInternacion { get; set; }

    public byte? InternadoCriterioClinico { get; set; }

    public byte? CuidadosIntensivos { get; set; }

    public DateOnly? FechaCuidadosInt { get; set; }

    public bool? AltaCuidadosInt { get; set; }

    public bool? FallecidoCuidadosInt { get; set; }

    public DateOnly? FechaAltaFallec { get; set; }

    public byte? Arm { get; set; }

    public DateOnly? FechaArm { get; set; }

    public byte? BuenaEvolucion { get; set; }

    public byte? TrabajadorSalud { get; set; }

    public bool ResidenteInsScep { get; set; }

    public string? NombreInsScep { get; set; }

    public bool AntecVacunaAntigripal { get; set; }

    public DateOnly? FechaVacunaAntigripal { get; set; }

    public byte? SintEstrechoConfConv { get; set; }

    public string? NombreSecc { get; set; }

    public string? Dnisecc { get; set; }

    public byte? SintEstrechoConfNoConv { get; set; }

    public string? NombreSecnc { get; set; }

    public string? Dnisecnc { get; set; }

    public byte? SintConglomConf { get; set; }

    public byte? SintCentroAsist { get; set; }

    public string? NombreSca { get; set; }

    public byte? PersonalSaludPaciente { get; set; }

    public byte? PersonalSaludPersonal { get; set; }

    public byte? ZonaRiesgoExterior { get; set; }

    public DateOnly? FechaZre { get; set; }

    public string? LugarZre { get; set; }

    public byte? ZonaRiesgoPais { get; set; }

    public DateOnly? FechaZrp { get; set; }

    public string? LugarZrp { get; set; }

    public byte? TransmComunitaria { get; set; }

    public byte? AsintConfEspeciales { get; set; }

    public byte TipoMuestra { get; set; }

    public string? OtraMuestra { get; set; }

    public string EstabMuestra { get; set; } = null!;

    public DateOnly FechaMuestra { get; set; }

    public string EstabDerivaMuestra { get; set; } = null!;

    public DateOnly FechaDerivaMuestra { get; set; }

    public string? ObservacionesEstrechos { get; set; }

    public DateOnly FechaNotificacion { get; set; }

    public string UsuarioNotifica { get; set; } = null!;

    public string UsuarioCarga { get; set; } = null!;

    public DateOnly FechaCarga { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateOnly? FechaAnula { get; set; }

    public string? ObservacionesAnula { get; set; }

    public DateOnly? FechaInternadoCritClin { get; set; }

    public string? EstabPrimeraConsulta { get; set; }

    public string? MotivoAnula { get; set; }

    public string? UsuarioImprime { get; set; }

    public DateOnly? FechaImprime { get; set; }

    public byte? OrigenNotificacion { get; set; }

    public int? TurnoId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public virtual ICollection<ContactosEstrechos> ContactosEstrechos { get; set; } = new List<ContactosEstrechos>();

    public virtual TipoEtnia Etnia { get; set; } = null!;

    public virtual Instituciones Institucion { get; set; } = null!;

    public virtual ICollection<NotificacionCovidResidencia> NotificacionCovidResidencia { get; set; } = new List<NotificacionCovidResidencia>();

    public virtual Pacientes Paciente { get; set; } = null!;
}
