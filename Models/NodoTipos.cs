using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoTipos
{
    public int NodoTipoId { get; set; }

    public string Detalle { get; set; } = null!;

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? InstitucionId { get; set; }
}
