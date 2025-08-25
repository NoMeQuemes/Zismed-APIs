using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoMovimientoBanco
{
    public int TipoMovimientosBancoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
