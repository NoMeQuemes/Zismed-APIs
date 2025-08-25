using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotaPedidoPresupuestoDetalle
{
    public int NotaPedidoPresupuestoDetalleId { get; set; }

    public int NotaPedidoPresupuestoId { get; set; }

    public int NotaPedidoDetalleId { get; set; }

    public decimal PrecioUnitario { get; set; }

    public bool Alternativo { get; set; }

    public virtual NotaPedidoDetalle NotaPedidoDetalle { get; set; } = null!;

    public virtual NotaPedidoPresupuesto NotaPedidoPresupuesto { get; set; } = null!;
}
