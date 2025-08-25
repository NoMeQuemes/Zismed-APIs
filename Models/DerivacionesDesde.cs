using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DerivacionesDesde
{
    public int DerivacionesDesdeId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? TablaExterna { get; set; }

    public string? TablaId { get; set; }
}
