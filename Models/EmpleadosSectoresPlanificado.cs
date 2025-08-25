using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadosSectoresPlanificado
{
    public int IdEmplaedoSectorPlanificado { get; set; }

    public int? EmpleadoId { get; set; }

    public int? SectorPlanificacionId { get; set; }

    public bool? Anulado { get; set; }

    public virtual EmpleadosHospital? Empleado { get; set; }

    public virtual SectorPlanificacion? SectorPlanificacion { get; set; }
}
