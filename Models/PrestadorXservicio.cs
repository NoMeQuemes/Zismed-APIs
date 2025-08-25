using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrestadorXservicio
{
    public int PrestadorXservicioId { get; set; }

    public int PrestadorId { get; set; }

    public int ServicioId { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? UsuarioBaja { get; set; }

    public bool? Interconsulta { get; set; }

    public bool? Ambulatorio { get; set; }
}
