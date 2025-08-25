using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoLugaresAltoRiesgoTrigger
{
    public int IdTrigger { get; set; }

    public int IdAltoRiesgo { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public bool? Activo { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string? Motivo { get; set; }
}
