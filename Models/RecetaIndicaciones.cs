using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RecetaIndicaciones
{
    public int IdReceta { get; set; }

    public int IdTurno { get; set; }

    public int IdPaciente { get; set; }

    public int? IdObraSocial { get; set; }

    public int? IdPlan { get; set; }

    public string? Plan { get; set; }

    public string? NroCarnet { get; set; }

    public DateOnly Fecha { get; set; }

    public int? IdPrestador { get; set; }

    public int? IdDiagnostico { get; set; }

    public int IdInstitucion { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public string? ObraSocialMigrada { get; set; }

    public bool? MigradoJardin { get; set; }

    public virtual ICollection<RecetaIndicacionesDetalle> RecetaIndicacionesDetalle { get; set; } = new List<RecetaIndicacionesDetalle>();
}
