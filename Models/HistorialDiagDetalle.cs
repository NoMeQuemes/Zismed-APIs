using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HistorialDiagDetalle
{
    public int HistorialDiagDetalleId { get; set; }

    public int HistorialDiagInternacionId { get; set; }

    public int DiagnosticoId { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaRetirado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? Nombre { get; set; }

    public int? InternacionId { get; set; }
}
