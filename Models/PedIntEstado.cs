using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedIntEstado
{
    public int PedIntEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descrpcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<PedIntDetalleRetirar> PedIntDetalleRetirar { get; set; } = new List<PedIntDetalleRetirar>();

    public virtual ICollection<PedIntEstadoHistorico> PedIntEstadoHistorico { get; set; } = new List<PedIntEstadoHistorico>();

    public virtual ICollection<PedidoInternoDetalle> PedidoInternoDetalle { get; set; } = new List<PedidoInternoDetalle>();
}
