using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class UnificacionUsHc
{
    public int UnificacionId { get; set; }

    public string? Nombre { get; set; }

    public string? Documento { get; set; }

    public int PacienteId { get; set; }

    public int? PacienteIdhc { get; set; }

    public DateOnly FechaModificacion { get; set; }

    public string Operador { get; set; } = null!;

    public int? PacienteIdInactivo { get; set; }

    public int? PacienteInactivoIdhc { get; set; }

    public bool? Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }
}
