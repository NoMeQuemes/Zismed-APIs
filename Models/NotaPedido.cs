using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NotaPedido
{
    public int NotaPedidoId { get; set; }

    public int PedidoLugarEntregaId { get; set; }

    public string DirigidaA { get; set; } = null!;

    public int NotaPedidoEstadoId { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public int? MedioCompraId { get; set; }

    public decimal PrecioEstimadoTotal { get; set; }

    public string? NroExpediente { get; set; }

    public string? RefExpediente { get; set; }

    public string? NroAsunto { get; set; }

    public int? NotaPedidoPresupuestoIdganador { get; set; }

    public int? PresupuestoMotivoGanadorId { get; set; }

    public int? ExpedienteId { get; set; }

    public virtual MedioCompra? MedioCompra { get; set; }

    public virtual ICollection<NotaPedidoDetalle> NotaPedidoDetalle { get; set; } = new List<NotaPedidoDetalle>();

    public virtual NotaPedidoEstado NotaPedidoEstado { get; set; } = null!;

    public virtual ICollection<NotaPedidoEstadoHistorico> NotaPedidoEstadoHistorico { get; set; } = new List<NotaPedidoEstadoHistorico>();

    public virtual ICollection<NotaPedidoPresupuesto> NotaPedidoPresupuesto { get; set; } = new List<NotaPedidoPresupuesto>();

    public virtual ICollection<OrdenCompra> OrdenCompra { get; set; } = new List<OrdenCompra>();

    public virtual ICollection<PartidasAafectar> PartidasAafectar { get; set; } = new List<PartidasAafectar>();

    public virtual PedidoLugarEntrega PedidoLugarEntrega { get; set; } = null!;

    public virtual PresupuestoMotivoGanador? PresupuestoMotivoGanador { get; set; }

    public virtual ICollection<PresupuestoResolucion> PresupuestoResolucion { get; set; } = new List<PresupuestoResolucion>();
}
