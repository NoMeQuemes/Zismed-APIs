using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Turnos
{
    public int TurnoId { get; set; }

    public int PacienteId { get; set; }

    public int ServicioId { get; set; }

    public int ConsultorioId { get; set; }

    public int PrestadorId { get; set; }

    public DateTime FechaHora { get; set; }

    public string HoraHasta { get; set; } = null!;

    public string? Orden { get; set; }

    public DateTime? Llegada { get; set; }

    public DateTime? Llamado { get; set; }

    public DateTime? Atendido { get; set; }

    public DateTime? NoAtendido { get; set; }

    public bool? Primeravez { get; set; }

    public int? AnterirorId { get; set; }

    public int? ObraSocialId { get; set; }

    public bool? Emergencia { get; set; }

    public short? EmergenciaId { get; set; }

    public bool Admisionado { get; set; }

    public short? Edad { get; set; }

    public string? OpCrea { get; set; }

    public string? OpModifica { get; set; }

    public DateTime? FecModifica { get; set; }

    public bool? Inyectable { get; set; }

    public int? TipoCuraciones { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaCrea { get; set; }

    public int? Curaciones { get; set; }

    public int? ShockRoom { get; set; }

    public string? TerminaAtencion { get; set; }

    public string? ComienzaAtencion { get; set; }

    public int? ConsultorioVisorId { get; set; }

    public int? NomExpedienteId { get; set; }

    public DateTime? FechaModifica { get; set; }

    public int? IdTurnoConsulta { get; set; }

    public int? InstitucionId { get; set; }

    public int? TurnoIdoriginal { get; set; }

    public bool? TeleSalud { get; set; }

    public int? TipoTeleSaludId { get; set; }

    public bool? Replanificado { get; set; }

    public int? BonoId { get; set; }

    public bool? TurnoProtegido { get; set; }

    public DateTime? BloqueoTat { get; set; }

    public DateTime? DatosCompletos { get; set; }

    public DateTime? DesbloqueoTat { get; set; }

    public string? UserDesbloqueaTat { get; set; }

    public int? LlamaAdmision { get; set; }

    public DateTime? LlamadoAdmision { get; set; }

    public int? TurnoRelacionado { get; set; }

    public int? ConsultorioIdadmision { get; set; }

    public int? Unificado { get; set; }

    public int? MotivoConsultaId { get; set; }

    public int? JurisdiccionId { get; set; }

    public bool? ConfirmadoWpp { get; set; }

    public bool? LlamadoPeroNoAtendido { get; set; }

    public virtual ICollection<AdmisionImagenes> AdmisionImagenes { get; set; } = new List<AdmisionImagenes>();

    public virtual ICollection<AdmisionLaboratorio> AdmisionLaboratorio { get; set; } = new List<AdmisionLaboratorio>();

    public virtual ICollection<ImagenRegistro> ImagenRegistro { get; set; } = new List<ImagenRegistro>();

    public virtual ICollection<LaboratorioRegistro> LaboratorioRegistro { get; set; } = new List<LaboratorioRegistro>();

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual Servicios Servicio { get; set; } = null!;

    public virtual ICollection<TurnosQuirofano> TurnosQuirofano { get; set; } = new List<TurnosQuirofano>();
}
