using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarVentasPagos
{
    public int IdExtraPagos { get; set; }

    public int IdEncabezadoVenta { get; set; }

    public short IdFormaPago { get; set; }

    public short Cuotas { get; set; }

    public decimal ValorCuota { get; set; }

    public bool Credito { get; set; }

    public bool Anulado { get; set; }

    public virtual FarEncabezadoVenta IdEncabezadoVentaNavigation { get; set; } = null!;
}
