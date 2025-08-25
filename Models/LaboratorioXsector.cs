using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioXsector
{
    public int LaboratorioXsectorId { get; set; }

    public int LaboratorioId { get; set; }

    public int? SectorId { get; set; }

    public string? SectorNombre { get; set; }

    public int? TipoSectorId { get; set; }

    public string? TipoNombre { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
