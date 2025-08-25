using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomEventoEncabezado
{
    public int ShockRoomEventoEncabezadoId { get; set; }

    public DateTime Fecha { get; set; }

    public int Id { get; set; }

    public int ShockRoomTipoAnamnesisId { get; set; }

    public bool Activo { get; set; }

    public string Crea { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<ShockRoomEventoDetalle> ShockRoomEventoDetalle { get; set; } = new List<ShockRoomEventoDetalle>();

    public virtual ShockRoomTipoAnamnesis ShockRoomTipoAnamnesis { get; set; } = null!;
}
