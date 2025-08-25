using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Cie10
{
    public int DiagnosticoId { get; set; }

    public string Capitulo { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? DesdeHasta { get; set; }

    public int Nivel { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<AnaemnesisObstetricia> AnaemnesisObstetricia { get; set; } = new List<AnaemnesisObstetricia>();

    public virtual ICollection<AnemnesisPuerperio> AnemnesisPuerperioDiagnosticoPrincipalNavigation { get; set; } = new List<AnemnesisPuerperio>();

    public virtual ICollection<AnemnesisPuerperio> AnemnesisPuerperioDiagnosticoSecundarioNavigation { get; set; } = new List<AnemnesisPuerperio>();

    public virtual ICollection<DiagnosticosInternado> DiagnosticosInternado { get; set; } = new List<DiagnosticosInternado>();

    public virtual ICollection<FojaQuirurjica> FojaQuirurjica { get; set; } = new List<FojaQuirurjica>();
}
