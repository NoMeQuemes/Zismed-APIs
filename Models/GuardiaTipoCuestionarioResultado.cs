using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaTipoCuestionarioResultado
{
    public int GuardiaTipoCuestionarioResultadoId { get; set; }

    public int GuardiaAnamnesisId { get; set; }

    public int GuardiaTipoCuestionarioPreguntaId { get; set; }

    public string? Resultado { get; set; }

    public bool Anulado { get; set; }

    public virtual GuardiaTipoCuestionarioPregunta GuardiaTipoCuestionarioPregunta { get; set; } = null!;
}
