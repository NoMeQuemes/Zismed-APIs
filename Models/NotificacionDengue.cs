using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotificacionDengue
{
    public int NotiDengueId { get; set; }

    public int PacienteId { get; set; }

    public string? Establecimiento { get; set; }

    public string? Provincia { get; set; }

    public string? Departamento { get; set; }

    public DateOnly? FechaNotificacion { get; set; }

    public string? NombreNotificador { get; set; }

    public string? Telefono { get; set; }

    public string? Mail { get; set; }

    public string? NombrePaciente { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? ProvinciaResidencia { get; set; }

    public string? DepartamentoResidencia { get; set; }

    public string? LocalidadResidencia { get; set; }

    public string? CalleDomicilio { get; set; }

    public string? NumeroDomicilio { get; set; }

    public string? PisoDomicilio { get; set; }

    public string? DeptoDomicilio { get; set; }

    public string? CodigoPostal { get; set; }

    public string? TelefonoPac { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Edad { get; set; }

    public string? SexoAlNacer { get; set; }

    public string? SexoLegal { get; set; }

    public string? Genero { get; set; }

    public string? Ocupacion { get; set; }

    public bool? PuebloIndigena { get; set; }

    public string? Etnia { get; set; }

    public int? InstitucionId { get; set; }

    public DateOnly FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateOnly? FechaModifica { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateOnly? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public string? FechaInicioFiebre { get; set; }

    public DateOnly? FechaInicioSintomas { get; set; }

    public string? TipoAtencion { get; set; }

    public bool? PersonaGestante { get; set; }

    public DateOnly? FechaConsulta { get; set; }

    public string? EstablecimientoConsulta { get; set; }

    public bool? ConsultaPrevia { get; set; }

    public DateOnly? FechaConsultaPrevia { get; set; }

    public bool? HidratacionParenteral { get; set; }

    public string? OtroTratamientoPrevio { get; set; }

    public string? DetalleOtroTratamiento { get; set; }

    public int? TurnoId { get; set; }

    public int? InternacionId { get; set; }

    public DateOnly? FechaInternacion { get; set; }

    public int? GuardiaId { get; set; }

    public bool? Embarazada { get; set; }

    public bool? Anulado { get; set; }

    public int? TipoLaboralId { get; set; }

    public bool? FiebreMas38 { get; set; }

    public bool? Cefalea { get; set; }

    public bool? Mialgia { get; set; }

    public bool? Artralagia { get; set; }

    public bool? DolorRetOcular { get; set; }

    public bool? DolorAbdominal { get; set; }

    public bool? DolorAbdInt { get; set; }

    public bool? VomitoPer { get; set; }

    public bool? Derrame { get; set; }

    public bool? Malestar { get; set; }

    public bool? Metrorragia { get; set; }

    public bool? Anorexia { get; set; }

    public bool? Nauceas { get; set; }

    public bool? Diarrea { get; set; }

    public bool? InyeConjunti { get; set; }

    public bool? Astenia { get; set; }

    public bool? Exantema { get; set; }

    public bool? Prurito { get; set; }

    public bool? Hematemesis { get; set; }

    public bool? Hepatomegalia { get; set; }

    public bool? Esplenomegalia { get; set; }

    public bool? Leucopenia { get; set; }

    public bool? Distress { get; set; }

    public bool? Oligoanuria { get; set; }

    public bool? SindHemo { get; set; }

    public bool? Tos { get; set; }

    public bool? Disnea { get; set; }

    public bool? Hipotension { get; set; }

    public bool? Taquipnea { get; set; }

    public bool? ShockHipo { get; set; }

    public bool? Miocarditis { get; set; }

    public bool? Trombocitopenia { get; set; }

    public bool? SindConfusional { get; set; }

    public bool? SindMenigneo { get; set; }

    public bool? Encefalitis { get; set; }

    public string? Rxtorax { get; set; }

    public bool? Petequias { get; set; }

    public bool? Purpura { get; set; }

    public bool? Ictericia { get; set; }

    public bool? Epistaxis { get; set; }

    public bool? Convulsiones { get; set; }

    public bool? Gingivorragia { get; set; }

    public bool? Letargo { get; set; }

    public bool? Hemoptisis { get; set; }

    public bool? AumentoHema { get; set; }

    public bool? Melena { get; set; }

    public bool? VomitosNegros { get; set; }

    public bool? Otro { get; set; }

    public bool? Viaje { get; set; }

    public DateOnly? FechaViaje { get; set; }

    public DateOnly? FechaRegreso { get; set; }

    public string? DestinoViaje { get; set; }

    public bool? EsMonitoreo { get; set; }

    public bool? EsCampo { get; set; }

    public bool? ContactoAnimal { get; set; }

    public bool? CasoSimilar { get; set; }

    public bool? TuvoDengue { get; set; }

    public string? AnoDengue { get; set; }

    public bool? VacAntiamarillica { get; set; }

    public DateOnly? FechaVacAntiamarillica { get; set; }

    public bool? VacDengue { get; set; }

    public DateOnly? FechaVacDengue { get; set; }

    public string? DosisDengue { get; set; }

    public bool? VacFiebreHa { get; set; }

    public DateOnly? FechaVacFiebreHa { get; set; }

    public bool? VacLeptospirosis { get; set; }

    public DateOnly? FechaVacLeptospirosis { get; set; }

    public bool? Vivo { get; set; }

    public DateOnly? FechaAlta { get; set; }

    public DateOnly? FechaDefuncion { get; set; }

    public string? TratPrevio { get; set; }

    public int? PrestadorId { get; set; }

    public bool? SinComor { get; set; }

    public bool? Diabetes { get; set; }

    public bool? Obesidad { get; set; }

    public bool? Hipertension { get; set; }

    public bool? Cardio { get; set; }

    public bool? Neuro { get; set; }

    public bool? Respi { get; set; }

    public bool? Renal { get; set; }

    public bool? Sida { get; set; }

    public bool? Inmuno { get; set; }

    public bool? Onco { get; set; }

    public bool? Endo { get; set; }

    public bool? OncoHema { get; set; }

    public bool? Alcoholismo { get; set; }

    public bool? Drogas { get; set; }

    public bool? HemoPatia { get; set; }

    public bool? HemoCro { get; set; }

    public bool? Reuma { get; set; }

    public string? OtraEnf { get; set; }

    public string? Hto { get; set; }

    public string? Gb { get; set; }

    public string? Neutrofilos { get; set; }

    public string? Linfocitos { get; set; }

    public string? Monocitos { get; set; }

    public string? Basofilos { get; set; }

    public string? Eosinofilos { get; set; }

    public string? Plaquetas { get; set; }

    public string? Vsg { get; set; }

    public string? Urea { get; set; }

    public string? Creatinina { get; set; }

    public string? AltGpt { get; set; }

    public string? AstGot { get; set; }

    public string? Fal { get; set; }

    public string? EstablecimientoInternacion { get; set; }

    public string? TerapiaIntensiva { get; set; }

    public DateOnly? FechaInternacionUti { get; set; }

    public string? RequerimientoArm { get; set; }

    public DateOnly? FechaArm { get; set; }

    public string? MedicoTratante { get; set; }

    public string? TelefonoMedicoTratante { get; set; }

    public string? Fallecido { get; set; }

    public DateOnly? FechaFallecimiento { get; set; }

    public string? EstablecimientoTomaMuestra { get; set; }

    public DateOnly? FechaPrimeraMuestra { get; set; }

    public DateOnly? FechaSegundaMuestra { get; set; }

    public bool? Suero { get; set; }

    public bool? Tejidos { get; set; }

    public bool? SangreEntera { get; set; }

    public bool? Plasma { get; set; }

    public bool? SueroPareado { get; set; }

    public bool? Lcr { get; set; }

    public bool? Orina { get; set; }

    public bool? Coagulo { get; set; }

    public string? Otra { get; set; }

    public string? TipoCaso { get; set; }

    public string? TipoCampo { get; set; }

    public string? ImportadoPais { get; set; }

    public string? ImportadoProv { get; set; }

    public string? ImportadoDepto { get; set; }

    public string? ImportadoLoc { get; set; }

    public string? LocalidadMonitoreo { get; set; }

    public DateOnly? FechaEsCampo { get; set; }

    public string? EsCampoLugar { get; set; }

    public string? ContactoAnimalCual { get; set; }

    public string? CasoSimilarQuien { get; set; }

    public string? EnfermedadZika { get; set; }

    public string? FiebreAmarilla { get; set; }

    public string? Hantavirus { get; set; }

    public string? Leptospirosis { get; set; }

    public string? Chikungunya { get; set; }

    public string? EncefalitisSanLuis { get; set; }

    public string? FiebreHemorrArgentina { get; set; }

    public string? Rickettsiosis { get; set; }

    public string? EncefalitisEquinaOeste { get; set; }

    public string? FiebreNiloOccidental { get; set; }

    public string? Paludismo { get; set; }

    public string? OtroSospecha { get; set; }

    public string? OtrosEspecificar { get; set; }

    public string? Dengue { get; set; }

    public bool? Dssa { get; set; }

    public bool? Dcsa { get; set; }

    public bool? Dg { get; set; }

    public string? UsuarioImprime { get; set; }

    public DateOnly? FechaImprime { get; set; }

    public virtual Pacientes Paciente { get; set; } = null!;
}
