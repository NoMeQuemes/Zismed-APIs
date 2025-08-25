using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CovidTipoReporte
{
    public int IdTipoReporte { get; set; }

    public string Tipo { get; set; } = null!;
}
