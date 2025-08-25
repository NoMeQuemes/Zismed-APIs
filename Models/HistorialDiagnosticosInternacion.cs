using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HistorialDiagnosticosInternacion
{
    public int HistorialDiagInternacionId { get; set; }

    public DateTime Fecha { get; set; }

    public int PrestadorId { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public int? DiagId { get; set; }

    public string? Nombre { get; set; }

    public int InternacionId { get; set; }

    public string? DetalleDiag { get; set; }

    public string? ListaDiagnosticos { get; set; }
}
