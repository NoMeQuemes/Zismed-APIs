using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FormatoConsentimiento
{
    public int FormatoConsentimientoId { get; set; }

    public string? Nombre { get; set; }

    public string? Detalle { get; set; }

    public int? InstitucionId { get; set; }

    public int? TipoConsentimientoId { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public bool? TieneObservacion { get; set; }

    public bool? Editable { get; set; }

    public bool? EncabezadoPaciente { get; set; }

    public bool? EncabezadoPrestador { get; set; }
}
