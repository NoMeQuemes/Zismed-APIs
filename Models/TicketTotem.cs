using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TicketTotem
{
    public int TicketId { get; set; }

    public int? PacienteId { get; set; }

    public string? Documento { get; set; }

    public string MotivoDerivacion { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }
}
