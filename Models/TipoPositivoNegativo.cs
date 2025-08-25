using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoPositivoNegativo
{
    public int TipoPositivoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AnaemnesisObstetricia> AnaemnesisObstetricia { get; set; } = new List<AnaemnesisObstetricia>();
}
