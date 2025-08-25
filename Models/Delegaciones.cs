using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Delegaciones
{
    public short IdDelegacion { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? IdLocalidad { get; set; }

    public string? Domicilio { get; set; }

    public bool Anulado { get; set; }

    public bool? Informatizada { get; set; }

    public bool? TrabajaComoIosepsalud { get; set; }

    public string? Telefono { get; set; }

    public bool? ConsultasInf { get; set; }

    public bool? MonodrogasInf { get; set; }

    public bool? PracticasInf { get; set; }

    public bool Limitrofe { get; set; }

    public int? IdProvLimitrofe { get; set; }
}
