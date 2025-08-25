using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class UsuarioConsultorioAdmins
{
    public int UsuarioConsultorioAdminId { get; set; }

    public string UsuarioId { get; set; } = null!;

    public int ConsultorioId { get; set; }

    public DateTime? Vigencia { get; set; }

    public bool? Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }
}
