using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoValor
{
    public int TipoValorId { get; set; }

    public string Detalle { get; set; } = null!;

    public string Tabla { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<DetalleTipoRespuesta> DetalleTipoRespuesta { get; set; } = new List<DetalleTipoRespuesta>();

    public virtual ICollection<TipoRespuesta> TipoRespuesta { get; set; } = new List<TipoRespuesta>();
}
