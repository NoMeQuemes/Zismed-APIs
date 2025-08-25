using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MotivoProtegidoPaciente
{
    public int IdMotivoPaciente { get; set; }

    public int IdMotivoProtegido { get; set; }

    public int IdPaciente { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public int? CantidadTotal { get; set; }

    public int? CantidadDisponible { get; set; }

    public int? IdServicio { get; set; }

    public int? IdPrestador { get; set; }

    public string? Motivo { get; set; }

    public virtual MotivoProtegido IdMotivoProtegidoNavigation { get; set; } = null!;
}
