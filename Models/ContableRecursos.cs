using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ContableRecursos
{
    public int ContableRecursosId { get; set; }

    public int PresupuestoContableId { get; set; }

    public int CuentaContableId { get; set; }

    public decimal ImporteEstimado { get; set; }

    public decimal? ImporteAmpliacion { get; set; }

    public decimal? ImporteEfectivo { get; set; }

    public decimal? ImporteDiferencias { get; set; }

    public DateOnly? FechaAprobacion { get; set; }

    public DateOnly? FechaAmpliacion { get; set; }

    public bool Anulado { get; set; }

    public virtual CuentasContables CuentaContable { get; set; } = null!;
}
