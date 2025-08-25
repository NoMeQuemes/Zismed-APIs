using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class VigenciaTerminosCondiciones
{
    public int VigenciaId { get; set; }

    public int InstitucionId { get; set; }

    public DateTime FechaVigencia { get; set; }

    public DateTime FechaCrea { get; set; }

    public string TerminosyCondiciones { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? TerminosCondicionesCorto { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public string? MotivoAnula { get; set; }
}
