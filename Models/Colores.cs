using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Colores
{
    public int ColorId { get; set; }

    public string? Nombre { get; set; }

    public string? ColorHexa { get; set; }

    public bool Anulado { get; set; }
}
