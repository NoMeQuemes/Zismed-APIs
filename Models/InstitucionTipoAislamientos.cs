using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InstitucionTipoAislamientos
{
    public int InstitucionTiposAislamientosId { get; set; }

    public int InstitucionId { get; set; }

    public int TipoAislamientoId { get; set; }

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }
}
