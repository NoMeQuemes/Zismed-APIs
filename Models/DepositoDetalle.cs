using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DepositoDetalle
{
    public int DetalleId { get; set; }

    public int EncabezadoId { get; set; }

    public int NroRegistro { get; set; }

    public decimal Cantidad { get; set; }

    public bool Anulado { get; set; }

    public virtual DepositoEncabezado Encabezado { get; set; } = null!;

    public virtual Articulos NroRegistroNavigation { get; set; } = null!;
}
