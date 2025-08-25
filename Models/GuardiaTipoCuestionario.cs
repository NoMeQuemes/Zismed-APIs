using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaTipoCuestionario
{
    public int GuardiaTipoCuestionarioId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<GuardiaAnamnesis> GuardiaAnamnesis { get; set; } = new List<GuardiaAnamnesis>();

    public virtual ICollection<GuardiaTipoCuestionarioPregunta> GuardiaTipoCuestionarioPregunta { get; set; } = new List<GuardiaTipoCuestionarioPregunta>();

    public virtual ICollection<GuardiaTipoCuestionarioXsector> GuardiaTipoCuestionarioXsector { get; set; } = new List<GuardiaTipoCuestionarioXsector>();
}
