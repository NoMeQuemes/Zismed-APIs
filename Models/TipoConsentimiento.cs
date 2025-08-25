using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoConsentimiento
{
    public int TipoConsentimientoId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }
}
