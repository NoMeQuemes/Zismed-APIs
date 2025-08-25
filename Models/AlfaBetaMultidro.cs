using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AlfaBetaMultidro
{
    public int NroRegistro { get; set; }

    /// <summary>
    /// Archivo nuevadro.txt
    /// </summary>
    public int NuevaDro { get; set; }

    public virtual AlfaBetaManualDat NroRegistroNavigation { get; set; } = null!;

    public virtual AlfaBetaNuevadro NuevaDroNavigation { get; set; } = null!;
}
