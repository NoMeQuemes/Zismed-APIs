using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TurnosReplanificados
{
    public int TurnoRepId { get; set; }

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

    public DateTime? FechaReplanificado { get; set; }
}
