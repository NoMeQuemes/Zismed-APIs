using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersTipoTrabajo
{
    public int PersTipoTrabajoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public string ColorMostrar { get; set; } = null!;

    public bool Planifica { get; set; }

    public string? Abreviatura { get; set; }

    public virtual ICollection<PersPlanificacionDetalle> PersPlanificacionDetalle { get; set; } = new List<PersPlanificacionDetalle>();
}
