using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AsistenciaMedicosPlanillas
{
    public int AsistenciaMedicoPlanillaId { get; set; }

    public DateOnly? Fecha { get; set; }

    public TimeOnly? Ingreso { get; set; }

    public TimeOnly? Egreso { get; set; }

    public string? Observacion { get; set; }

    public int? AsistenciaMedicoId { get; set; }

    public int? PracticaId { get; set; }

    public int? SectorId { get; set; }

    public bool DiaSiguiente { get; set; }

    public DateOnly? DiaPertenece { get; set; }

    public bool Anulado { get; set; }
}
