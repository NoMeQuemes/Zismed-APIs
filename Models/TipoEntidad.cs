using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoEntidad
{
    public int TipoEntidadId { get; set; }

    public string DescripcionEntidad { get; set; } = null!;
}
