using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoAnualAfectacion
{
    public int PresupuestoAnualAfectacionId { get; set; }

    public int PresupuestoAnualDetalleId { get; set; }

    public int NroAsiento { get; set; }

    public decimal Importe { get; set; }

    public int? RefAsientoId { get; set; }

    public string? RefAsiento { get; set; }

    public DateTime FechaCarga { get; set; }

    public string Usuario { get; set; } = null!;

    public int? NotaPedidoId { get; set; }

    public string? NroExpediente { get; set; }

    public DateOnly? FechaAfectacion { get; set; }

    public bool AsientoBis { get; set; }

    public int? ExpedienteId { get; set; }

    public decimal SaldoPartida { get; set; }

    public bool Desafectada { get; set; }

    public bool Ajustada { get; set; }

    public int? FondoPermanenteId { get; set; }

    public virtual ICollection<AfectacionesXresolucion> AfectacionesXresolucion { get; set; } = new List<AfectacionesXresolucion>();

    public virtual PresupuestoAnualDetalle PresupuestoAnualDetalle { get; set; } = null!;

    public virtual ICollection<PresupuestoCompromiso> PresupuestoCompromiso { get; set; } = new List<PresupuestoCompromiso>();
}
