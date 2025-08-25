using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AlfaBetaGtin1
{
    public int NroRegistro { get; set; }

    public string Gtin { get; set; } = null!;

    public virtual AlfaBetaManualDat NroRegistroNavigation { get; set; } = null!;
}
