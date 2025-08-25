using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarIdentificacionCompras
{
    public int IdIdentificacionCompras { get; set; }

    public int IdDetalleCompras { get; set; }

    public int? IdDetalleVentas { get; set; }

    public string NroSerie { get; set; } = null!;

    public string NroLote { get; set; } = null!;

    public DateOnly Vence { get; set; }

    public bool Anulado { get; set; }

    public virtual FarDetalleVentas? IdDetalleVentasNavigation { get; set; }
}
