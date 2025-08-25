using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Lotes
{
    public int LoteId { get; set; }

    public string NroLote { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? ObraSocialId { get; set; }

    public string? NroFactura { get; set; }

    public int? TramiteEstadoId { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaCrea { get; set; }

    public DateTime? FechaAnula { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCierra { get; set; }

    public string? Periodo { get; set; }

    public DateTime? FechaPresentado { get; set; }

    public DateTime? FechaExtendido { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<NomExpediente> NomExpediente { get; set; } = new List<NomExpediente>();
}
