using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoAnualMovimiento
{
    public int PresupuestoAnualMovimientoId { get; set; }

    public decimal Importe { get; set; }

    public bool Inicial { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public int PresupuestoAnualDetalleId { get; set; }

    public int? PresupuestoMovEntrePartidasId { get; set; }

    public int? PresupuestoConceptoId { get; set; }

    public int? ExpedienteId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? SaldoPartida { get; set; }

    public virtual PresupuestoAnualDetalle PresupuestoAnualDetalle { get; set; } = null!;

    public virtual PresupuestoConcepto? PresupuestoConcepto { get; set; }

    public virtual PresupuestoMovEntrePartidas? PresupuestoMovEntrePartidas { get; set; }
}
