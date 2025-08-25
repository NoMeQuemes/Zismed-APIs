using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EvolucionZismedIosep
{
    public int EvolucionZismedIosepid { get; set; }

    public int EvolucionHcwebId { get; set; }

    public int InternacionId { get; set; }

    public string Evolucion { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? EvolucionIosepid { get; set; }

    public string? UsuarioActualiza { get; set; }

    public DateTime? FechaActualiza { get; set; }
}
