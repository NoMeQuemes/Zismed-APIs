using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Grupos
{
    public int GrupoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<GruposPersonas> GruposPersonas { get; set; } = new List<GruposPersonas>();
}
