using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PracticaTurnos
{
    public int PracticaTurnoId { get; set; }

    public int PracticaBaseId { get; set; }

    public int TurnoId { get; set; }

    public bool Anulado { get; set; }

    public virtual PracticasBase PracticaBase { get; set; } = null!;
}
