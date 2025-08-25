using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoOsculta
{
    public int OscultaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneralFisicoGeneralR3Navigation { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneralFisicoGeneralR4Navigation { get; set; } = new List<AnaemnesisGeneral>();
}
