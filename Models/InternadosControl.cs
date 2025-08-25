using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InternadosControl
{
    public int ControlInternacionId { get; set; }

    public int InternacionId { get; set; }

    public string? Tarjeta { get; set; }

    public DateOnly Fecha { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UserCrea { get; set; } = null!;

    public string? OpAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public bool Anulado { get; set; }

    public int? EncabezadoPreBonoId { get; set; }

    public int? SectorId { get; set; }

    public int NumeroDia { get; set; }

    public bool MedioDia { get; set; }

    public int? IdControlIosep { get; set; }
}
