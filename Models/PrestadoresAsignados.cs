using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrestadoresAsignados
{
    public int PrestadorAsignadoId { get; set; }

    public int IdAdmision { get; set; }

    public int PacienteId { get; set; }

    public int PrestadorId { get; set; }

    public string UsuarioAsigna { get; set; } = null!;

    public DateTime FechaAsigna { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }
}
