using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PacientesObraSocial
{
    public int PacienteObraSocialId { get; set; }

    public int ObraSocialId { get; set; }

    public int PacienteId { get; set; }

    public bool Activo { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? NroAfiliado { get; set; }

    public string? Coseguro { get; set; }

    public int? PlanId { get; set; }

    public int? CoseguroId { get; set; }
}
