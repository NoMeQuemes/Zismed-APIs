using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LoteRegXestado
{
    public int LoteRegXestadoId { get; set; }

    public int LoteId { get; set; }

    public bool Anulado { get; set; }

    public int? TramiteEstadoId { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }
}
