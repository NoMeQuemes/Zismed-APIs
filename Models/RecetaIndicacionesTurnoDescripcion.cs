using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RecetaIndicacionesTurnoDescripcion
{
    public int IdTurnoReceta { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdInstitucion { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? Letra { get; set; }
}
