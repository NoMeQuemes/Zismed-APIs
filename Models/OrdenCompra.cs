using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenCompra
{
    public int OrdenCompraId { get; set; }

    public int NotaPedidoId { get; set; }

    public int OrdenCompraEstadoId { get; set; }

    public decimal ImporteTotal { get; set; }

    public int? NroOrdenCompra { get; set; }

    public DateOnly FechaOrden { get; set; }

    public DateTime FechaCrea { get; set; }

    public int? ExpedienteId { get; set; }

    public int? NotaPedidoPresupuestoId { get; set; }

    public virtual NotaPedido NotaPedido { get; set; } = null!;

    public virtual OrdenCompraEstado OrdenCompraEstado { get; set; } = null!;

    public virtual ICollection<OrdenCompraEstadoHistorico> OrdenCompraEstadoHistorico { get; set; } = new List<OrdenCompraEstadoHistorico>();

    public virtual ICollection<OrdenCompraRecepcion> OrdenCompraRecepcion { get; set; } = new List<OrdenCompraRecepcion>();

    public virtual ICollection<OrdenPago> OrdenPago { get; set; } = new List<OrdenPago>();
}
