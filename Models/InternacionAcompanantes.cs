using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InternacionAcompanantes
{
    public int IdAcompananteInternado { get; set; }

    public int InternacionId { get; set; }

    public int IdAcompanante { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public int? IdTipoParentezco { get; set; }

    public string? TelefonoAcompanante { get; set; }

    public string? DomicilioAcompanante { get; set; }

    public virtual Pacientes IdAcompananteNavigation { get; set; } = null!;

    public virtual Internaciones Internacion { get; set; } = null!;
}
