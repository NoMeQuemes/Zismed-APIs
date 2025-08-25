using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomDerivInt
{
    public int ShockRoomDerivIntId { get; set; }

    public int ShockRoomRegistroId { get; set; }

    public int ShockRoomTipoAnamnesisId { get; set; }

    public int ShockRoomCamasId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public bool Activo { get; set; }

    public virtual ShockRoomCamas ShockRoomCamas { get; set; } = null!;

    public virtual ShockRoomTipoAnamnesis ShockRoomTipoAnamnesis { get; set; } = null!;
}
