using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PlanObraSocial
{
    public int PlanObraSocialId { get; set; }

    public int ObraSocialId { get; set; }

    public int PlanId { get; set; }

    public int? InstitucionId { get; set; }

    public bool? Anulado { get; set; }

    public string? UserCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UserModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string? UserAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
