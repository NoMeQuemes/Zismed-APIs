using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ProductosXdeposito
{
    public int ProductoId { get; set; }

    public int DepositoId { get; set; }

    public decimal Stock { get; set; }

    public decimal? LugaresDisponibles { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public virtual Depositos Deposito { get; set; } = null!;

    public virtual Productos Producto { get; set; } = null!;
}
