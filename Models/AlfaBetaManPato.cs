using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AlfaBetaManPato
{
    public int IdPatologia { get; set; }

    public int Monodro { get; set; }

    public virtual Patologias IdPatologiaNavigation { get; set; } = null!;

    public virtual AlfaBetaMonoDro MonodroNavigation { get; set; } = null!;
}
