using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenCompraEstado
{
    public int OrdenCompraEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<OrdenCompra> OrdenCompra { get; set; } = new List<OrdenCompra>();

    public virtual ICollection<OrdenCompraEstadoHistorico> OrdenCompraEstadoHistorico { get; set; } = new List<OrdenCompraEstadoHistorico>();
}
