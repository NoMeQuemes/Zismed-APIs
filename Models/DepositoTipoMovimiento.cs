using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DepositoTipoMovimiento
{
    public int TipoMovimientoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<DepositoEncabezado> DepositoEncabezado { get; set; } = new List<DepositoEncabezado>();
}
