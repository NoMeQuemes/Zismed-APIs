using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InformeDigital
{
    public int InformeDigitalId { get; set; }

    public string Nombre { get; set; } = null!;

    public int TipoInformeDigitalId { get; set; }

    public int PacienteId { get; set; }

    public int? TurnoId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? Imagen { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioMod { get; set; }

    public string? FechaMod { get; set; }

    public bool? Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual TipoInformeDigital TipoInformeDigital { get; set; } = null!;
}
