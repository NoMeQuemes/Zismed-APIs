using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ApgarRn
{
    public int ApgarId { get; set; }

    public int AnamnesisRnid { get; set; }

    public string Valor { get; set; } = null!;

    public int Minutos { get; set; }

    public bool Anulado { get; set; }
}
