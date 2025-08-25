using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoTeleSalud
{
    public int TipoTeleSaludId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }
}
