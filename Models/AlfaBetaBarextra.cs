using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AlfaBetaBarextra
{
    public int NroRegistro { get; set; }

    public string CodigoBarra { get; set; } = null!;

    public virtual AlfaBetaManualDat NroRegistroNavigation { get; set; } = null!;
}
