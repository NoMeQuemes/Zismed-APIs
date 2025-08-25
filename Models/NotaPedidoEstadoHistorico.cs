using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotaPedidoEstadoHistorico
{
    public int NotaPedidoEstadoHistoricoId { get; set; }

    public int NotaPedidoId { get; set; }

    public int NotaPedidoEstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual NotaPedido NotaPedido { get; set; } = null!;

    public virtual NotaPedidoEstado NotaPedidoEstado { get; set; } = null!;
}
