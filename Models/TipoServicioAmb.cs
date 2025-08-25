using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoServicioAmb
{
    public int TipoServicioAmbId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }

    public bool? EsPractica { get; set; }
}
