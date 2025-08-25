using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Planes
{
    public int IdPlan { get; set; }

    public string Nombre { get; set; } = null!;

    public bool GrupoFliar { get; set; }

    public string? Relacion { get; set; }

    public bool? Especial { get; set; }

    public bool? Estandar { get; set; }

    public int? DiasVence { get; set; }

    public bool? Informacion { get; set; }

    public bool? Iosep { get; set; }

    public bool Anulado { get; set; }

    public string? OperModif { get; set; }

    public DateTime? FechaModif { get; set; }

    public string? OperAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public bool FueraProvincia { get; set; }

    public bool DiasCobertura { get; set; }

    public bool? Online { get; set; }

    public bool? Hc { get; set; }
}
