using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Cie10Capitulos
{
    public int CapituloId { get; set; }

    public string Nivel { get; set; } = null!;

    public string DesdeHasta { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
