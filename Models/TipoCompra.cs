using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoCompra
{
    public int TipoCompraId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
