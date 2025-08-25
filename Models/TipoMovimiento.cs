using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoMovimiento
{
    public int TipoMovimientoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
