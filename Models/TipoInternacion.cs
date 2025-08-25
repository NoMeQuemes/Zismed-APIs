using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoInternacion
{
    public int TipoInternacionId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public int? IdtipoHc { get; set; }

    public int? IosepTipoInternacionId { get; set; }

    public int? Idp { get; set; }

    public DateOnly? Vigencia { get; set; }
}
