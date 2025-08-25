using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Consentimientos
{
    public int ConsentimientoId { get; set; }

    public int? PacienteId { get; set; }

    public int? TurnoId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaId { get; set; }

    public int? InstitucionId { get; set; }

    public string? Observacion { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaImprime { get; set; }

    public DateTime? FechaFirma { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? Urlimagen { get; set; }

    public string? StringImagen { get; set; }

    public string? UsuarioCarga { get; set; }

    public int? PrestadorId { get; set; }

    public string? Detalle { get; set; }

    public bool? Editado { get; set; }

    public int? FormatoConsentimientoId { get; set; }
}
