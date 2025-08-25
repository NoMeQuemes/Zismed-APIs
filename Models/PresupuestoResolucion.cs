using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoResolucion
{
    public int PresupuestoResolucionId { get; set; }

    public string NroResolucion { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string Usuario { get; set; } = null!;

    public int? PresupuestoAnualDetalleId { get; set; }

    public int? NotaPedidoId { get; set; }

    public int PresupuestoResolucionEstadoId { get; set; }

    public string? NroExpediente { get; set; }

    public DateOnly? FechaResolucion { get; set; }

    public int? ExpedienteId { get; set; }

    public virtual ICollection<AfectacionesXresolucion> AfectacionesXresolucion { get; set; } = new List<AfectacionesXresolucion>();

    public virtual NotaPedido? NotaPedido { get; set; }

    public virtual ICollection<PresupuestoCompromiso> PresupuestoCompromiso { get; set; } = new List<PresupuestoCompromiso>();

    public virtual PresupuestoResolucionEstado PresupuestoResolucionEstado { get; set; } = null!;

    public virtual ICollection<PresupuestoResolucionEstadoHistorial> PresupuestoResolucionEstadoHistorial { get; set; } = new List<PresupuestoResolucionEstadoHistorial>();
}
