using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AsistenciaEmpleado
{
    public int AsistenciaId { get; set; }

    public int EmpleadoId { get; set; }

    public int? PersPlanificacionId { get; set; }

    public int? PersPlanificacionDetalleId { get; set; }

    public DateTime? HoraIngreso { get; set; }

    public DateTime? HoraEgreso { get; set; }

    public bool Anulado { get; set; }
}
