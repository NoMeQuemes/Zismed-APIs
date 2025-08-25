using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MedioCompra
{
    public int MedioCompraId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<NotaPedido> NotaPedido { get; set; } = new List<NotaPedido>();
}
