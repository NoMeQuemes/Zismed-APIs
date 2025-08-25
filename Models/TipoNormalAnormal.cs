using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoNormalAnormal
{
    public int TipoNormalId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AnaemnesisObstetricia> AnaemnesisObstetriciaBacteriuriaMayorVeinteNNavigation { get; set; } = new List<AnaemnesisObstetricia>();

    public virtual ICollection<AnaemnesisObstetricia> AnaemnesisObstetriciaBacteriuriaMenorVeinteNNavigation { get; set; } = new List<AnaemnesisObstetricia>();
}
