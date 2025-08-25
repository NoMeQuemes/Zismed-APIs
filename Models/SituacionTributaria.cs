using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class SituacionTributaria
{
    public short SituacionTribId { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal? Iva { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<Personas> Personas { get; set; } = new List<Personas>();
}
