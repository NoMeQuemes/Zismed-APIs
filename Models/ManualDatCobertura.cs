using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ManualDatCobertura
{
    public int IdManualDatCobertura { get; set; }

    public int? IdManual { get; set; }

    public DateOnly? FecAct { get; set; }

    public string? Troquel { get; set; }

    public string? Nombre { get; set; }

    public string? Present { get; set; }

    public string? Ioma { get; set; }

    public string? Laborat { get; set; }

    public decimal? CoberturaAmbulatorio { get; set; }

    public decimal? CoberturaInternado { get; set; }

    public DateOnly? VigenciaCobertura { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Registro { get; set; }

    public string? Barras { get; set; }

    public bool Anulado { get; set; }
}
