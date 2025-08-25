using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoPrefesionalQuirofano
{
    public int TipoProfesionalQuirofanoId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }

    public int? EspecialistaIosepId { get; set; }
}
