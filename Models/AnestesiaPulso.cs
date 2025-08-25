using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnestesiaPulso
{
    public int AnestesiaPulsoId { get; set; }

    public int? Max { get; set; }

    public int? Min { get; set; }

    public decimal? PulsoFrecuencia { get; set; }

    public int? AnestesiaFormularioId { get; set; }

    public bool? Anulado { get; set; }

    public virtual AnestesiaFormulario? AnestesiaFormulario { get; set; }
}
