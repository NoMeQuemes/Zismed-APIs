using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoPosicion
{
    public int TipoPosicionId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<IndicacionesPosicion> IndicacionesPosicion { get; set; } = new List<IndicacionesPosicion>();
}
