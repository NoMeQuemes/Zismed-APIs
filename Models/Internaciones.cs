using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Internaciones
{
    public int InternacionId { get; set; }

    public int PacienteId { get; set; }

    public int? PacienteReferenciaId { get; set; }

    public int HabitacionId { get; set; }

    public int CamaId { get; set; }

    public int ObraSocialId { get; set; }

    public bool Hijo { get; set; }

    public string? HijoNombre { get; set; }

    public string? FamiliarReferente { get; set; }

    public string? TelefonoReferente { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public string HoraIngreso { get; set; } = null!;

    public int PrestadorIngresoId { get; set; }

    public int MotivoIngresoId { get; set; }

    public DateOnly? FechaAlta { get; set; }

    public string? HoraAlta { get; set; }

    public int? PrestadorAltaId { get; set; }

    public int? TipoAltaId { get; set; }

    public string? DerivadoA { get; set; }

    public string? OcupacionHabitual { get; set; }

    public string? Observaciones { get; set; }

    public bool Anulado { get; set; }

    public int? NomExpedienteId { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaRegistraAlta { get; set; }

    public int? InternacionReferenciaId { get; set; }

    public bool? CompartenCama { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public int? InternacionIdmod { get; set; }

    public string? OtroMedioTraslado { get; set; }

    public int? CentroId { get; set; }

    public int? MovilId { get; set; }

    public string? Motivo { get; set; }

    public string? OtroCentro { get; set; }

    public string? EstudiosComp { get; set; }

    public string? MedicacionSum { get; set; }

    public string? Antecedentes { get; set; }

    public int? IdinternacionHc { get; set; }

    public int? InstitucionId { get; set; }

    public bool? NoConsiderar { get; set; }

    public int? IdInternadoIosep { get; set; }

    public bool? EstadoAfiliado { get; set; }

    public bool? Upcn { get; set; }

    public string? NumeroFamiliar { get; set; }

    public int? DiagnosticoId { get; set; }

    public bool? Clinica { get; set; }

    public bool? Consentimiento { get; set; }

    public int? DiagnosticoIosepId { get; set; }

    public bool? Particular { get; set; }

    public bool? EpicrisisSinCargar { get; set; }

    public bool? CargaAcompanante { get; set; }

    public DateTime? FechaAnulaIosep { get; set; }

    public DateOnly? FechaAltaAdmin { get; set; }

    public DateOnly? FechaForza { get; set; }

    public string? UsuarioForza { get; set; }

    public virtual ICollection<AnaemnesisReducida> AnaemnesisReducida { get; set; } = new List<AnaemnesisReducida>();

    public virtual ICollection<DiagnosticosInternado> DiagnosticosInternado { get; set; } = new List<DiagnosticosInternado>();

    public virtual ICollection<Epicrisis> Epicrisis { get; set; } = new List<Epicrisis>();

    public virtual ICollection<Evolucion> Evolucion { get; set; } = new List<Evolucion>();

    public virtual ICollection<FojaQuirurjica> FojaQuirurjica { get; set; } = new List<FojaQuirurjica>();

    public virtual HabitacionesHospital Habitacion { get; set; } = null!;

    public virtual ICollection<ImagenRegistro> ImagenRegistro { get; set; } = new List<ImagenRegistro>();

    public virtual ICollection<Interconsulta> Interconsulta { get; set; } = new List<Interconsulta>();

    public virtual ICollection<InternacionAcompanantes> InternacionAcompanantes { get; set; } = new List<InternacionAcompanantes>();

    public virtual ICollection<MedicacionPaciente> MedicacionPaciente { get; set; } = new List<MedicacionPaciente>();

    public virtual TipoIngresos MotivoIngreso { get; set; } = null!;

    public virtual ICollection<MovimientosInternaciones> MovimientosInternaciones { get; set; } = new List<MovimientosInternaciones>();

    public virtual ObraSocial ObraSocial { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual ICollection<PrescripcionEncabezado> PrescripcionEncabezado { get; set; } = new List<PrescripcionEncabezado>();

    public virtual Prestadores? PrestadorAlta { get; set; }

    public virtual Prestadores PrestadorIngreso { get; set; } = null!;

    public virtual ICollection<RevistaSala> RevistaSala { get; set; } = new List<RevistaSala>();

    public virtual TipoAltaIntenado? TipoAlta { get; set; }
}
