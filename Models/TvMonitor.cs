using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TvMonitor
{
    public int TvMonitorId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public int? TipoLlamadorId { get; set; }

    public virtual ICollection<Consultorios> Consultorios { get; set; } = new List<Consultorios>();
}
