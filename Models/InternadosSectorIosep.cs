using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InternadosSectorIosep
{
    public int SectorId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
