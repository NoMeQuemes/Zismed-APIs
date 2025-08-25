using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AlfaBetaExtraBarras
{
    public int NroRegistro { get; set; }

    public string? CodigoBarra { get; set; }

    public string? Troquel { get; set; }

    public virtual AlfaBetaManualDat NroRegistroNavigation { get; set; } = null!;
}
