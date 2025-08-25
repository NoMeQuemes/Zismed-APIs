using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ShockRoomCamas
{
    public int ShockRoomCamasId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Cama { get; set; }

    public bool Box { get; set; }

    public bool Ocupada { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<ShockRoomDerivInt> ShockRoomDerivInt { get; set; } = new List<ShockRoomDerivInt>();
}
