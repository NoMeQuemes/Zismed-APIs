using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoRazonTrabajo
{
    public int TipoRazonTrabajoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
