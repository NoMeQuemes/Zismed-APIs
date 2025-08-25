using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PracticasXtipoInternacion
{
    public int PracticaXtipoInternacionId { get; set; }

    public int PracticaBaseId { get; set; }

    public int TipoInternacionId { get; set; }

    public int? Cantidad { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateOnly? FechaCrea { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateOnly? FechaModifica { get; set; }

    public bool? Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateOnly? FechaAnula { get; set; }
}
