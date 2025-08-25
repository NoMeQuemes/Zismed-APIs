using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AceptaTerminosCondiciones
{
    public int AceptaId { get; set; }

    public string UsuarioId { get; set; } = null!;

    public int InstitucionId { get; set; }

    public DateTime FechaAcepta { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public bool? Acepta { get; set; }

    public int? VigenciaId { get; set; }
}
