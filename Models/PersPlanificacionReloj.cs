using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersPlanificacionReloj
{
    public int IdPersPlanificacionReloj { get; set; }

    public int IdEmpleado { get; set; }

    public int IdReloj { get; set; }

    public string Dni { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public DateTime? FechaProcesa { get; set; }

    public bool? Anulado { get; set; }
}
