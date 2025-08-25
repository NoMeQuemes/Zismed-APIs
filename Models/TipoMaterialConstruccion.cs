using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoMaterialConstruccion
{
    public int TipoMateriaConsId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AnalisisSocioEconomico> AnalisisSocioEconomico { get; set; } = new List<AnalisisSocioEconomico>();
}
