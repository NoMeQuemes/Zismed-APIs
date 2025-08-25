using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnestesiaMedicacion
{
    public int AnestesiaMedicacionId { get; set; }

    public int? AnestesiaFormularioId { get; set; }

    public int? ArticuloFarmaciaCisId { get; set; }

    public bool? PostOperatorio { get; set; }

    public bool? Fluido { get; set; }

    public int? Cantidad { get; set; }

    public bool? Anulado { get; set; }

    public virtual AnestesiaFormulario? AnestesiaFormulario { get; set; }

    public virtual ArticulosFarmaciaCis? ArticuloFarmaciaCis { get; set; }
}
