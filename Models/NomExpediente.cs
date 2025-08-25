using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomExpediente
{
    public int NomExpedienteId { get; set; }

    public int PacienteId { get; set; }

    public int? LoteId { get; set; }

    public string? NroExpediente { get; set; }

    public string? Dni { get; set; }

    public string? Nombre { get; set; }

    public string? Prestador { get; set; }

    public int? PrestadorId { get; set; }

    public int? PrestadorFirmaId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public int? TurnoId { get; set; }

    public int? ObraSocialId { get; set; }

    public string? ObraSocial { get; set; }

    public string? CodigoRefes { get; set; }

    public DateTime? ImprimeComprobante { get; set; }

    public DateTime? ImprimeNotificacion { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public DateOnly? FechaEgreso { get; set; }

    public int? TotalDias { get; set; }

    public string? DiagIngreso { get; set; }

    public string? DiagEgreso { get; set; }

    public string? UsuarioCarga { get; set; }

    public DateTime? FechaCarga { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public DateTime? ImprimePlanillaPract { get; set; }

    public bool Anulado { get; set; }

    public string? OpImpComprobante { get; set; }

    public string? OpImprimeNotif { get; set; }

    public string? DetNotificacion { get; set; }

    public bool? PagoParcial { get; set; }

    public int? EstadoNotificacion { get; set; }

    public string? MotivoRechazo { get; set; }

    public DateTime? FechaRechazo { get; set; }

    public int? NroExpedienteOrden { get; set; }

    public int? InstitucionId { get; set; }

    public int? LoteRegPagoId { get; set; }

    public virtual Lotes? Lote { get; set; }
}
