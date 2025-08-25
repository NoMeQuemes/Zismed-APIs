using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarTipoMovimiento
{
    public int IdTipoMovimiento { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string VentaCompra { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<FarEncabezadoCompras> FarEncabezadoCompras { get; set; } = new List<FarEncabezadoCompras>();
}
