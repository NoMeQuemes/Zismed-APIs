using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FojaQuirurjica
{
    public int FojaQuirurjicaId { get; set; }

    public int InternacionId { get; set; }

    public int MovimientoId { get; set; }

    public string? HoraInicio { get; set; }

    public string? HoraFin { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Diagnostico { get; set; }

    public int? DiagnosticoId { get; set; }

    public string? DiagnosticoPreoperatorio { get; set; }

    public string? DiagnosticoPostoperatorio { get; set; }

    public string? OperacionHallazgos { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public int? PrestadorId { get; set; }

    public bool? Anulado { get; set; }

    public virtual ICollection<CirujiaDetalle> CirujiaDetalle { get; set; } = new List<CirujiaDetalle>();

    public virtual Cie10? DiagnosticoNavigation { get; set; }

    public virtual Internaciones Internacion { get; set; } = null!;
}
