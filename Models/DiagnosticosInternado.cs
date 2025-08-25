using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DiagnosticosInternado
{
    public int DiagnosticosInternadoId { get; set; }

    public int InternacionId { get; set; }

    public bool DiagnosticoPrincipal { get; set; }

    public int DiagnosticoId { get; set; }

    public DateOnly Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public string IngresoAlta { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Cie10 Diagnostico { get; set; } = null!;

    public virtual Internaciones Internacion { get; set; } = null!;
}
