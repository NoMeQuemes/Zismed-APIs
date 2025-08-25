using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenCompraRecepcion
{
    public int OrdenCompraRecepcionId { get; set; }

    public int OrdenCompraId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual OrdenCompra OrdenCompra { get; set; } = null!;

    public virtual ICollection<OrdenCompraRecepcionDetalle> OrdenCompraRecepcionDetalle { get; set; } = new List<OrdenCompraRecepcionDetalle>();
}
