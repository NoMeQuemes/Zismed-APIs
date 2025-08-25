using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoMarcaAlfaBeta
{
    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AlfaBetaManualDat> AlfaBetaManualDat { get; set; } = new List<AlfaBetaManualDat>();
}
