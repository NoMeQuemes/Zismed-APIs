using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class BaseCisb
{
    public double? F1 { get; set; }

    public string? Nombre { get; set; }

    public string? Cuil { get; set; }

    public string? TipoDeContratación { get; set; }

    public string? TipoContrataciónReal { get; set; }

    public string? PuestoCargo { get; set; }

    public string? PuestoCargoCambios { get; set; }

    public string? Especialidad { get; set; }

    public string? LugarDeTrabajo { get; set; }

    public string? ServicioÁrea { get; set; }

    public string? DíaLaboral { get; set; }

    public string? HorarioLaboral { get; set; }

    public string? Escolaridad { get; set; }

    public string? Comentarios { get; set; }

    public bool? Anulado { get; set; }
}
