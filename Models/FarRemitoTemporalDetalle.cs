using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarRemitoTemporalDetalle
{
    public int IdDetalleTemporal { get; set; }

    public int IdEncabezadoTemporal { get; set; }

    public int NroRegistro { get; set; }

    public string Articulo { get; set; } = null!;

    public int? NuevaDro { get; set; }

    public string? Gtin { get; set; }

    public string? CodBarras { get; set; }

    public decimal Cantidad { get; set; }

    public string? Lote { get; set; }

    public string? Vence { get; set; }

    public string? RemitoNumero { get; set; }

    public int EstadoId { get; set; }

    public decimal? CantidadRecibida { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<FarRemitoTemporalDetalleLoteVto> FarRemitoTemporalDetalleLoteVto { get; set; } = new List<FarRemitoTemporalDetalleLoteVto>();

    public virtual FarRemitoTemporalEncabezado IdEncabezadoTemporalNavigation { get; set; } = null!;
}
