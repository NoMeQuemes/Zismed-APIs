using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DietasNodo
{
    public int DietaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Detalle { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? OpCrea { get; set; }

    public string? OpAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
