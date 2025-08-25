using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AsientoXpartida
{
    public int AsientoXpartidaId { get; set; }

    public DateTime FechaCrea { get; set; }

    public int NroAsiento { get; set; }

    public int? RefAsientoId { get; set; }

    public string? RefAsiento { get; set; }

    public int? ExpedienteId { get; set; }

    public string Concepto { get; set; } = null!;

    public int PresupuestoAnualDetalleId { get; set; }

    public int? PresupuestoAnualMovimientoId { get; set; }

    public int? CuentaBancariaDetalleMovimientoId { get; set; }

    public int? PresupuestoAnualAfectacionId { get; set; }

    public int? PresupuestoCompromisoId { get; set; }

    public int? OrdenPagoId { get; set; }

    public int? PresupuestoResolucionId { get; set; }

    public bool AsientosBis { get; set; }

    public string? Observaciones { get; set; }

    public DateOnly FechaMuestra { get; set; }

    public int? FondoPermanenteId { get; set; }
}
