using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AlfaBetaRegNueva
{
    public int NroRegistro { get; set; }

    public int MonoDro { get; set; }

    public string Potencia { get; set; } = null!;

    public int UPotenci { get; set; }

    public virtual AlfaBetaNuevadro MonoDroNavigation { get; set; } = null!;

    public virtual AlfaBetaManualDat NroRegistroNavigation { get; set; } = null!;

    public virtual AlfaBetaUPotenci UPotenciNavigation { get; set; } = null!;
}
