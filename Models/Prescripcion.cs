using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Prescripcion
{
    public int PrescripcionId { get; set; }

    public bool Anulado { get; set; }

    public string? Observaciones { get; set; }

    public int? DiagnosticoId { get; set; }

    public string? Diagnostico { get; set; }

    public DateTime FechaPrescribe { get; set; }

    public int PrestadorId { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public int PrescripcionEncabezadoId { get; set; }

    public DateTime? FechaImpresion { get; set; }

    public string? UsuarioImprime { get; set; }

    public virtual ICollection<PrescripcionDetalle> PrescripcionDetalle { get; set; } = new List<PrescripcionDetalle>();

    public virtual PrescripcionEncabezado PrescripcionEncabezado { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;
}
