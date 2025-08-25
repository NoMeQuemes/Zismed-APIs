using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class VwGrillaTurnos
{
    public string Matricula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Expr1 { get; set; } = null!;

    public string Expr2 { get; set; } = null!;

    public string Expr3 { get; set; } = null!;

    public string? MDesde { get; set; }

    public string? MHasta { get; set; }

    public string? TDesde { get; set; }

    public string? THasta { get; set; }

    public string? NDesde { get; set; }

    public string? NHasta { get; set; }

    public string? Frecuencia { get; set; }

    public bool Anulado { get; set; }
}
