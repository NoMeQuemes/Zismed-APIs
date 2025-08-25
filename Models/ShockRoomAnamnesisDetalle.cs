using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomAnamnesisDetalle
{
    public int ShockRoomAnamnesisDetalleId { get; set; }

    public int ShockRoomTipoAnamnesisId { get; set; }

    public int Orden { get; set; }

    public string Pregunta { get; set; } = null!;

    public bool Obligatorio { get; set; }

    public int TipoRespuestaId { get; set; }

    public string? ValorMaximo { get; set; }

    public string? ValorMinimo { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<ShockRoomEventoDetalle> ShockRoomEventoDetalle { get; set; } = new List<ShockRoomEventoDetalle>();

    public virtual ShockRoomTipoAnamnesis ShockRoomTipoAnamnesis { get; set; } = null!;

    public virtual TipoRespuesta TipoRespuesta { get; set; } = null!;
}
