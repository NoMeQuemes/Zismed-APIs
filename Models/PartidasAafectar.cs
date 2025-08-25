using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PartidasAafectar
{
    public int PartidasAafectarId { get; set; }

    public int PresupuestoAnualDetalleId { get; set; }

    public int NotaPedidoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual NotaPedido NotaPedido { get; set; } = null!;

    public virtual PresupuestoAnualDetalle PresupuestoAnualDetalle { get; set; } = null!;
}
