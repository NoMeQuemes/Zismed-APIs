using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoInternoDetalle
{
    public int PedidoInternoDetalleId { get; set; }

    public int PedidoInternoId { get; set; }

    public int? NroRegistro { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public string? Observaciones { get; set; }

    public string? TipoEntrega { get; set; }

    public int? IdMotivo { get; set; }

    public bool Anulado { get; set; }

    public DateTime FechaCrea { get; set; }

    public string OpCrea { get; set; } = null!;

    public DateTime? FechaModi { get; set; }

    public string? OpModi { get; set; }

    public int? ProductoId { get; set; }

    public int? PedIntEstadoId { get; set; }

    public decimal CantidadSaldo { get; set; }

    public virtual ICollection<NotaPedidoDetalle> NotaPedidoDetalle { get; set; } = new List<NotaPedidoDetalle>();

    public virtual ICollection<PedIntDetalleRetirar> PedIntDetalleRetirar { get; set; } = new List<PedIntDetalleRetirar>();

    public virtual PedIntEstado? PedIntEstado { get; set; }

    public virtual ICollection<PedIntEstadoHistorico> PedIntEstadoHistorico { get; set; } = new List<PedIntEstadoHistorico>();

    public virtual PedidoInterno PedidoInterno { get; set; } = null!;

    public virtual Productos? Producto { get; set; }
}
