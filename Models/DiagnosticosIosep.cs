using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DiagnosticosIosep
{
    public int IdDiagnostico { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Consultas { get; set; }

    public bool Anulado { get; set; }
}
