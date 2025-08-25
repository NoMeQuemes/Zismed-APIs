using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoRetencion
{
    public int TipoRetencionId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public decimal? ImporteMinimo { get; set; }

    public decimal? ProcentajeRetencion { get; set; }

    public decimal? AlicuotaBasica { get; set; }

    public decimal? ImporteIncremento { get; set; }

    public decimal? AlicuotaIncremento { get; set; }

    public decimal? ImporteMaximo { get; set; }

    public decimal? AlicuotaMaxima { get; set; }

    public bool Anulado { get; set; }
}
