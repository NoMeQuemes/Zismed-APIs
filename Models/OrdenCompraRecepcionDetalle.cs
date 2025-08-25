using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenCompraRecepcionDetalle
{
    public int OrdenCompraRecepcionDetalleId { get; set; }

    public int OrdenCompraRecepcionId { get; set; }

    public int ProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public bool Anulado { get; set; }

    public virtual OrdenCompraRecepcion OrdenCompraRecepcion { get; set; } = null!;
}
