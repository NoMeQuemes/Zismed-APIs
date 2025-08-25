using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotaPedidoEstado
{
    public int NotaPedidoEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<NotaPedido> NotaPedido { get; set; } = new List<NotaPedido>();

    public virtual ICollection<NotaPedidoEstadoHistorico> NotaPedidoEstadoHistorico { get; set; } = new List<NotaPedidoEstadoHistorico>();
}
