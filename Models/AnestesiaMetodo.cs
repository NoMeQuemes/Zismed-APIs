using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnestesiaMetodo
{
    public int AnestesiaMetodoId { get; set; }

    public int? AnestesiaFormularioId { get; set; }

    public virtual AnestesiaFormulario? AnestesiaFormulario { get; set; }
}
