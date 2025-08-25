using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Respiradores
{
    public int RespiradorId { get; set; }

    public string? Nombre { get; set; }

    public string? Modelo { get; set; }

    public int? EstadoEquipoId { get; set; }

    public bool Anulado { get; set; }

    public string? OpCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? OpAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? InstitucionId { get; set; }
}
