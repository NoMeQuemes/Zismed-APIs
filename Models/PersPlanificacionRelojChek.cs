using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersPlanificacionRelojChek
{
    public int IdPersPlanificacionRelojChek { get; set; }

    public int? IdPersPlanificacionRelojTurno { get; set; }

    public DateTime? Chequeo { get; set; }

    public string? Tipo { get; set; }

    public bool? Anulado { get; set; }

    public bool? Virtual { get; set; }
}
