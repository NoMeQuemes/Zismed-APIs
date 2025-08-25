using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoActualizacion
{
    public int TipoActualizacionId { get; set; }

    public string DescripcionActualizacion { get; set; } = null!;
}
