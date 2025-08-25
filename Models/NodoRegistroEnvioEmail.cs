using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoRegistroEnvioEmail
{
    public int NodoRegistroEnviosEmailId { get; set; }

    public DateTime? FechaRealiza { get; set; }

    public string? Correo { get; set; }

    public string? Detalle { get; set; }

    public string? OpRealiza { get; set; }

    public int? TipoReporte { get; set; }

    public string? Estado { get; set; }
}
