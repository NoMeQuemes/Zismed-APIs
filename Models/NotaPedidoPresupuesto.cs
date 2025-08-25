using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotaPedidoPresupuesto
{
    public int NotaPedidoPresupuestoId { get; set; }

    public int NotaPedidoId { get; set; }

    public int ProveedorId { get; set; }

    public bool Anulado { get; set; }

    public DateTime FechaCrea { get; set; }

    public string OpCrea { get; set; } = null!;

    public DateTime? FechaModi { get; set; }

    public string? OpModi { get; set; }

    public decimal ImporteTotal { get; set; }

    public virtual NotaPedido NotaPedido { get; set; } = null!;

    public virtual ICollection<NotaPedidoPresupuestoDetalle> NotaPedidoPresupuestoDetalle { get; set; } = new List<NotaPedidoPresupuestoDetalle>();

    public virtual Proveedores Proveedor { get; set; } = null!;
}
