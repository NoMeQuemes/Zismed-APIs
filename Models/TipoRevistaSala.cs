using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoRevistaSala
{
    public int TipoRevistaSalaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<RevistaSala> RevistaSala { get; set; } = new List<RevistaSala>();
}
