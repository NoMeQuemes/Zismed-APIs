using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoInternoDestinos
{
    public int PedidoInternoDestinosId { get; set; }

    public int PedidoInternoId { get; set; }

    public int PedidoSectorIddestino { get; set; }

    public bool Anulado { get; set; }

    public virtual PedidoInterno PedidoInterno { get; set; } = null!;

    public virtual PedidoSector PedidoSectorIddestinoNavigation { get; set; } = null!;
}
