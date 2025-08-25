using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersPlanificacionRelojTurno
{
    public int IdPersPlanificacionRelojTurno { get; set; }

    public int? IdPersPlanificacionReloj { get; set; }

    public string? TipoTurno { get; set; }

    public DateTime? FechaDia { get; set; }

    public string? HorasTurno { get; set; }

    public string? TipoEntrada { get; set; }

    public string? TipoSalida { get; set; }

    public bool? Anulado { get; set; }

    public string? Detalle { get; set; }

    public int? Tipo { get; set; }
}
