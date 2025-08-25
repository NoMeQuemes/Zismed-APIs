using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Quirofanos
{
    public int QuirofanoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool? SalaParto { get; set; }

    public bool? Anulado { get; set; }

    public int? InstitucionId { get; set; }
}
