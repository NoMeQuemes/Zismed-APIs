using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HcsnomedConcept
{
    public int IdConceptSnomed { get; set; }

    public string ConceptId { get; set; } = null!;

    public string Term { get; set; } = null!;

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
