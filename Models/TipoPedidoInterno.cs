using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoPedidoInterno
{
    public int TipoPedidoInternoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public decimal MontoDesde { get; set; }

    public decimal MontoHasta { get; set; }

    public string Normativa { get; set; } = null!;

    public bool GeneraOdenCompra { get; set; }

    public bool Anulado { get; set; }

    public string? OpCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? OpModi { get; set; }

    public DateTime? FechaModi { get; set; }

    public virtual ICollection<PedidoInternoEncabezado> PedidoInternoEncabezado { get; set; } = new List<PedidoInternoEncabezado>();
}
