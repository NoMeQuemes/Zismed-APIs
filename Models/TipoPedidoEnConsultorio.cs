using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoPedidoEnConsultorio
{
    public int TipoPedidoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<PedidosEnConsultorio> PedidosEnConsultorio { get; set; } = new List<PedidosEnConsultorio>();
}
