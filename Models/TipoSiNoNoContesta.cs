using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoSiNoNoContesta
{
    public int TipoSiNoNoContesta1 { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
