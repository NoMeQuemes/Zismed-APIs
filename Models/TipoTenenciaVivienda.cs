using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoTenenciaVivienda
{
    public int TipoTenenciaVivId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AnalisisSocioEconomico> AnalisisSocioEconomico { get; set; } = new List<AnalisisSocioEconomico>();
}
