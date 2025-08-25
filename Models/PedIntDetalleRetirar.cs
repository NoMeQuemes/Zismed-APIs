using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedIntDetalleRetirar
{
    public int PedIntDetalleRetirarId { get; set; }

    public int PedidoInternoDetalleId { get; set; }

    public decimal CantAretirar { get; set; }

    public int PedIntEstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public int DepositoId { get; set; }

    public virtual PedIntEstado PedIntEstado { get; set; } = null!;

    public virtual PedidoInternoDetalle PedidoInternoDetalle { get; set; } = null!;
}
