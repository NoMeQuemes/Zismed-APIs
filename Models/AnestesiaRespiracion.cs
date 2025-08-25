using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnestesiaRespiracion
{
    public int AnestesiaRespiracionId { get; set; }

    public decimal? Saturacion { get; set; }

    public decimal? RespiracionFrecuencia { get; set; }

    public int? AnestesiaFormularioId { get; set; }

    public bool? Anulado { get; set; }

    public virtual AnestesiaFormulario? AnestesiaFormulario { get; set; }
}
