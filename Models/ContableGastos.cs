using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ContableGastos
{
    public int ContableGastosId { get; set; }

    public int PresupuestoContableId { get; set; }

    public int CuentaContableId { get; set; }

    public decimal ImporteCredito { get; set; }

    public decimal? ImporteAmpliacion { get; set; }

    public decimal? AfectacionPreventiva { get; set; }

    public decimal? ImporteComprometido { get; set; }

    public decimal? AfectacionDefinitiva { get; set; }

    public decimal? MandadoApagar { get; set; }

    public DateOnly? FechaAprobacion { get; set; }

    public DateOnly? FechaAmpliacion { get; set; }

    public bool Anulado { get; set; }

    public virtual CuentasContables CuentaContable { get; set; } = null!;
}
