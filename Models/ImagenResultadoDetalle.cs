using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ImagenResultadoDetalle
{
    public int ImagenResultadoDetalleId { get; set; }

    public int ImagenResultadoId { get; set; }

    public int ImagenTipoOrganoId { get; set; }

    public string? Tamaño { get; set; }

    public string? Parenquima { get; set; }

    public string? Bordes { get; set; }

    public string? Paredes { get; set; }

    public string? Observacion { get; set; }

    public bool? Anulado { get; set; }

    public virtual ImagenResultado ImagenResultado { get; set; } = null!;
}
