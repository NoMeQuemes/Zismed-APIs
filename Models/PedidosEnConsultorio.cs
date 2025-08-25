using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidosEnConsultorio
{
    public int PedidoId { get; set; }

    public int ConsultaId { get; set; }

    public int TipoPedidoId { get; set; }

    public string Pedido { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ConsultasAmbulatorias Consulta { get; set; } = null!;

    public virtual TipoPedidoEnConsultorio TipoPedido { get; set; } = null!;
}
