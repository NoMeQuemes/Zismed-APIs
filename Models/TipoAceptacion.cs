using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoAceptacion
{
    public int TipoAceptacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
