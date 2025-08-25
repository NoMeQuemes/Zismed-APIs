using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoRespuesta
{
    public int TipoRespuestaId { get; set; }

    public string Detalle { get; set; } = null!;

    public string? ValoraAlmacenar { get; set; }

    public string? ValoraMostrar { get; set; }

    public string? Observaciones { get; set; }

    public int TipoValorId { get; set; }

    public string? TablaExterna { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<AnamnesisDetalle> AnamnesisDetalle { get; set; } = new List<AnamnesisDetalle>();

    public virtual ICollection<DetalleTipoRespuesta> DetalleTipoRespuesta { get; set; } = new List<DetalleTipoRespuesta>();

    public virtual ICollection<ShockRoomAnamnesisDetalle> ShockRoomAnamnesisDetalle { get; set; } = new List<ShockRoomAnamnesisDetalle>();

    public virtual TipoValor TipoValor { get; set; } = null!;
}
