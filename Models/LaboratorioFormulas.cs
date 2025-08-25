using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioFormulas
{
    public int LaboratorioFormulaId { get; set; }

    public string? Nombre { get; set; }

    public string? Detalle { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
