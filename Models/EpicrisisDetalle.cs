using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EpicrisisDetalle
{
    public int EpicrisisDetalleId { get; set; }

    public int EpicrisisId { get; set; }

    public string? Medicamento { get; set; }

    public string? Dosis { get; set; }

    public string? Via { get; set; }

    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public string? Tiempo { get; set; }

    public virtual Epicrisis Epicrisis { get; set; } = null!;
}
