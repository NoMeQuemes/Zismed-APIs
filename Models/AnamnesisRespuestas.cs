using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnamnesisRespuestas
{
    public int AnamnesisRespuestasId { get; set; }

    public int TipoRespuestaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
