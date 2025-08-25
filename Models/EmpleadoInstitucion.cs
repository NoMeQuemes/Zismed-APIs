using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadoInstitucion
{
    public int EmpleadoInstitucionId { get; set; }

    public int EmpleadoId { get; set; }

    public int InstitucionId { get; set; }

    public int? DdjjempleadoId { get; set; }

    public DateTime? FechaColocacion { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }
}
