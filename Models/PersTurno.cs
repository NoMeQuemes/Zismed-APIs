using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersTurno
{
    public int PersTurnoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<PersPlanificacionDetalle> PersPlanificacionDetalle { get; set; } = new List<PersPlanificacionDetalle>();
}
