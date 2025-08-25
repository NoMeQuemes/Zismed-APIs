using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomExpRegXestado
{
    public int NomExpRegxEstadoId { get; set; }

    public int NomExpedienteId { get; set; }

    public int TramiteEstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string? Detalle { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string? DatosEditados { get; set; }

    public bool Anulado { get; set; }
}
