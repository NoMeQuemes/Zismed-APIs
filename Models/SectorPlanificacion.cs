using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class SectorPlanificacion
{
    public int SectorPlanificacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? SectorId { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<EmpleadosSectoresPlanificado> EmpleadosSectoresPlanificado { get; set; } = new List<EmpleadosSectoresPlanificado>();
}
