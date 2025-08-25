using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoMamas
{
    public int TipoMamasId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<RevistaSalaObstetricia> RevistaSalaObstetricia { get; set; } = new List<RevistaSalaObstetricia>();
}
