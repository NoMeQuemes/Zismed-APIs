using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InternadosAfeccion
{
    public int AfeccionInternacionId { get; set; }

    public int InternacionId { get; set; }

    public string CodigoAfeccion { get; set; } = null!;

    public int PrestadorId { get; set; }

    public DateTime FechaHoraCrea { get; set; }

    public string OpCrea { get; set; } = null!;

    public DateTime? FechaHoraAnula { get; set; }

    public string? OpAnula { get; set; }

    public bool Activo { get; set; }

    public bool Anulado { get; set; }

    public string? NombreAfeccion { get; set; }

    public int? IdAfeccionIosep { get; set; }

    public string? MotivoAnula { get; set; }

    public DateTime? FechaHoraModifica { get; set; }

    public string? OpModifica { get; set; }
}
