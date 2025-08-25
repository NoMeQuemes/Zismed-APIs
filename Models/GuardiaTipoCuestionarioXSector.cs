using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaTipoCuestionarioXsector
{
    public int GuardiaTipoCuestionarioXsectorId { get; set; }

    public int GuardiaSectorId { get; set; }

    public int GuardiaTipoCuestionarioId { get; set; }

    public bool Anulado { get; set; }

    public virtual GuardiaTipoCuestionario GuardiaTipoCuestionario { get; set; } = null!;
}
