using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoCbancos
{
    public int TipoCbancoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<BancosPersonas> BancosPersonas { get; set; } = new List<BancosPersonas>();
}
