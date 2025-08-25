using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomEventoDetalle
{
    public int ShockRoomEventoDetalleId { get; set; }

    public int ShockRoomEventoEncabezadoId { get; set; }

    public int ShockRoomAnamnesisDetalleId { get; set; }

    public string? ValorAlmacenar { get; set; }

    public string? ValorId { get; set; }

    public bool Anulado { get; set; }

    public virtual ShockRoomAnamnesisDetalle ShockRoomAnamnesisDetalle { get; set; } = null!;

    public virtual ShockRoomEventoEncabezado ShockRoomEventoEncabezado { get; set; } = null!;
}
