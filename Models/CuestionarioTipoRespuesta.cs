using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CuestionarioTipoRespuesta
{
    public int CuestionarioTipoRespuestaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public bool Anulado { get; set; }
}
