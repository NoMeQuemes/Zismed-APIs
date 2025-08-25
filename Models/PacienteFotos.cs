using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PacienteFotos
{
    public int PacienteFotosId { get; set; }

    public int PacienteId { get; set; }

    public int TipoImagenId { get; set; }

    public string UrlImagen { get; set; } = null!;

    public string StringImagen { get; set; } = null!;

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public virtual TipoImagen TipoImagen { get; set; } = null!;
}
