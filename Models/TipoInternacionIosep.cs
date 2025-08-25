using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoInternacionIosep
{
    public int TipoInternacionId { get; set; }

    public string? Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Quirofano { get; set; }

    public bool RestriccionDia { get; set; }

    public bool EsAlta { get; set; }

    public bool Deriva { get; set; }

    public bool Anulado { get; set; }
}
