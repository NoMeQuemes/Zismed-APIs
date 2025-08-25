using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class InformeGeneral
{
    public int InformeGeneralId { get; set; }

    public int ImagenPracticaId { get; set; }

    public string? Titulo { get; set; }

    public string Informe { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public int? InstitucionId { get; set; }

    public int? Idp { get; set; }
}
