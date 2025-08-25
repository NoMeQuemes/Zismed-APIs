using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoTraslado
{
    public int TipoTrasladoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }
}
