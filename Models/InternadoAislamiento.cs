using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InternadoAislamiento
{
    public int IdInternadoAislamiento { get; set; }

    public int InternacionId { get; set; }

    public int IdTipoAislamiento { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UserCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string? UserModifica { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UserAnula { get; set; }

    public bool Anulado { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }
}
