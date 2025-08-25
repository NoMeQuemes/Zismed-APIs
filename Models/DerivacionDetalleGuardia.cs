using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DerivacionDetalleGuardia
{
    public int DerivacionDetalleGuardiaId { get; set; }

    public int DerivacionesEnviosId { get; set; }

    public int ShockRoomTipoAnamnesisId { get; set; }

    public int ShockRoomRegistroId { get; set; }

    public virtual DerivacionesEnvios DerivacionesEnvios { get; set; } = null!;

    public virtual ShockRoomRegistro ShockRoomRegistro { get; set; } = null!;

    public virtual ShockRoomTipoAnamnesis ShockRoomTipoAnamnesis { get; set; } = null!;
}
