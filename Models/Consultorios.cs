using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Consultorios
{
    public int ConsultorioId { get; set; }

    public string Nombre { get; set; } = null!;

    public int? EspecialidadId { get; set; }

    public int TvMonitorId { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public bool? EsAdmision { get; set; }

    public virtual ICollection<PlanillaTurnos> PlanillaTurnos { get; set; } = new List<PlanillaTurnos>();

    public virtual TvMonitor TvMonitor { get; set; } = null!;
}
