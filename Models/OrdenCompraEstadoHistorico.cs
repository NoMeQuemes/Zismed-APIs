using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenCompraEstadoHistorico
{
    public int OrdenCompraEstadoHistoricoId { get; set; }

    public int OrdenCompraEstadoId { get; set; }

    public int OrdenCompraId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual OrdenCompra OrdenCompra { get; set; } = null!;

    public virtual OrdenCompraEstado OrdenCompraEstado { get; set; } = null!;
}
