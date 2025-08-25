using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FondoPermanenteDetalle
{
    public int FondoPermanenteDetalleId { get; set; }

    public int FondoPermanenteId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public bool Anulado { get; set; }
}
