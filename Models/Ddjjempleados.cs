using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Ddjjempleados
{
    public int DdjjempleadoId { get; set; }

    public int InstitucionId { get; set; }

    public bool Confirmada { get; set; }

    public bool Nuevo { get; set; }

    public string? UsuarioConfirma { get; set; }

    public DateTime? FechaConfirma { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }
}
