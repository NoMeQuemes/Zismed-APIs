using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomServicios
{
    public int SockRoomServicioId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<ShockRoomTipoAnamnesis> ShockRoomTipoAnamnesis { get; set; } = new List<ShockRoomTipoAnamnesis>();
}
