using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoKinesiologia
{
    public int TipoKinesiologiaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<IndicacionesKinesiologia> IndicacionesKinesiologia { get; set; } = new List<IndicacionesKinesiologia>();
}
