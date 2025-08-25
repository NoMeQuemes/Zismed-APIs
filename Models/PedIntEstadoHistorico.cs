using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedIntEstadoHistorico
{
    public int PedIntEstadoHistoricoId { get; set; }

    public int PedidoInternoDetalleId { get; set; }

    public int PedIntEstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual PedIntEstado PedIntEstado { get; set; } = null!;

    public virtual PedidoInternoDetalle PedidoInternoDetalle { get; set; } = null!;
}
