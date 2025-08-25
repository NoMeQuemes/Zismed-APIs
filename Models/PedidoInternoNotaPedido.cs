using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoInternoNotaPedido
{
    public int PedidoInternoNotaPedidoId { get; set; }

    public int PedidoInternoDetalleId { get; set; }

    public int NotaPedidoDetalleId { get; set; }

    public bool Anulado { get; set; }
}
