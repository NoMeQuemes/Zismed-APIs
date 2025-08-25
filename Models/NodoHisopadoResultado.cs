using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoHisopadoResultado
{
    public int IdHisopadoResultado { get; set; }

    public int Resultado { get; set; }

    public DateOnly FechaResultado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public int IdHisopado { get; set; }

    public string? Observaciones { get; set; }

    public virtual NodoHisopado IdHisopadoNavigation { get; set; } = null!;
}
