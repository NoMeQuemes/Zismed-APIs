using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ParametrosHoraHabil
{
    public int IdParametroHoraHabil { get; set; }

    public string Nombre { get; set; } = null!;

    public int Horas { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public bool? AltaInternado { get; set; }

    public virtual ICollection<ParametrosHoraHabilDetalle> ParametrosHoraHabilDetalle { get; set; } = new List<ParametrosHoraHabilDetalle>();
}
