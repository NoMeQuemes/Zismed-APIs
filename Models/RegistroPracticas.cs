using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RegistroPracticas
{
    public int RegistroPracticaId { get; set; }

    public int? PacienteId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaId { get; set; }

    public int? TurnoId { get; set; }

    public int? PaseId { get; set; }

    public DateTime? FechaEmision { get; set; }

    public DateTime? FechaPrescripcion { get; set; }

    public string? Diagnostico { get; set; }

    public string? Observacion { get; set; }

    public int? PrestadorId { get; set; }

    public int? PlanId { get; set; }

    public string? PlanNombre { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public int? IdAfiliado { get; set; }

    public string? PaseNombre { get; set; }

    public int? AutorizacionId { get; set; }
}
