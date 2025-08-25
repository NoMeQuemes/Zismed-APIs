using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CuentaBancariaDetalleMovimiento
{
    public int CuentaBancariaDetalleMovimientoId { get; set; }

    public int CuentaBancariaId { get; set; }

    public int CuentaMovConceptoId { get; set; }

    public int? OrdenPagoDetalleId { get; set; }

    public int CuentaTipoMovimientoId { get; set; }

    public string? NroCheque { get; set; }

    public string? NroTransaccion { get; set; }

    public decimal Ingreso { get; set; }

    public decimal Egreso { get; set; }

    public decimal Saldo { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int? ExpedienteId { get; set; }

    public string? Observaciones { get; set; }

    public virtual CuentaBancaria CuentaBancaria { get; set; } = null!;

    public virtual CuentaMovConcepto CuentaMovConcepto { get; set; } = null!;

    public virtual CuentaTipoMovimiento CuentaTipoMovimiento { get; set; } = null!;

    public virtual OrdenPagoDetalle? OrdenPagoDetalle { get; set; }
}
