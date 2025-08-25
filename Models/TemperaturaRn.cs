using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TemperaturaRn
{
    public int TemperaturaId { get; set; }

    public int AnamnesisRnid { get; set; }

    public DateTime Minutos { get; set; }

    public decimal Temperatura { get; set; }

    public bool Anulado { get; set; }
}
