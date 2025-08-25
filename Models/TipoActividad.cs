using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoActividad
{
    public int TipoActividadId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
