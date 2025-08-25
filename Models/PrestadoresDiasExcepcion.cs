using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrestadoresDiasExcepcion
{
    public int PrestadoresDiasExcepcionId { get; set; }

    public string? Motivo { get; set; }

    public DateOnly? FechaDesde { get; set; }

    public DateOnly? FechaHasta { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? PrestadorId { get; set; }

    public int? PrestadoresInstitucionesId { get; set; }
}
