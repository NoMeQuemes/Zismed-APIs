using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoConsumirBono
{
    public int IdTipoConsumirBono { get; set; }

    public string? DescripcionConsumirBono { get; set; }

    public virtual ICollection<Instituciones> Instituciones { get; set; } = new List<Instituciones>();
}
