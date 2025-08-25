using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FeriadosAsuetos
{
    public int IdFeriadoAsueto { get; set; }

    public string Detalle { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public bool? Anulado { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? UsuarioModifica { get; set; }

    public string? UsuarioBorra { get; set; }
}
