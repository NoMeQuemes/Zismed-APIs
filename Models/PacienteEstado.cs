using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PacienteEstado
{
    public int PacienteEstadoId { get; set; }

    public int PacienteId { get; set; }

    public int EstadoId { get; set; }

    public int OrigenEstadoId { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime? FechaModifica { get; set; }

    public string? UsuarioModifica { get; set; }

    public bool Modificado { get; set; }

    public virtual OrigenEstado OrigenEstado { get; set; } = null!;

    public virtual Pacientes PacienteEstadoNavigation { get; set; } = null!;
}
