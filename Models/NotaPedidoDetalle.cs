using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotaPedidoDetalle
{
    public int NotaPedidoDetalleId { get; set; }

    public int? PedidoInternoDetalleId { get; set; }

    public int NotaPedidoId { get; set; }

    public int ProductoId { get; set; }

    public decimal PrecioUnitarioEstimado { get; set; }

    public decimal Cantidad { get; set; }

    public decimal CantidadAutorizada { get; set; }

    public virtual NotaPedido NotaPedido { get; set; } = null!;

    public virtual ICollection<NotaPedidoPresupuestoDetalle> NotaPedidoPresupuestoDetalle { get; set; } = new List<NotaPedidoPresupuestoDetalle>();

    public virtual PedidoInternoDetalle? PedidoInternoDetalle { get; set; }
}
