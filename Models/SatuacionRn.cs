using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class SatuacionRn
{
    public int SaturacionId { get; set; }

    public int AnamnesisRnid { get; set; }

    public int Valor { get; set; }

    public DateTime FechaHora { get; set; }

    public bool Anulado { get; set; }
}
