using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomencladorResolucion
{
    public int NomencladorResolucionId { get; set; }

    public int NomencladorId { get; set; }

    public string? Resolucion { get; set; }

    public decimal? Precio { get; set; }

    public DateOnly? FechaResolucion { get; set; }

    public DateOnly? FechaFin { get; set; }

    public bool Anulado { get; set; }

    public virtual Nomenclador Nomenclador { get; set; } = null!;
}
