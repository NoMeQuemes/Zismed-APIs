using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenPagoAsiento
{
    public int OrdenPagoAsientoId { get; set; }

    public int PresupuestoAnualDetalleId { get; set; }

    public int NroAsiento { get; set; }

    public int OrdenPagoId { get; set; }

    public decimal ImportePartida { get; set; }

    public virtual OrdenPago OrdenPago { get; set; } = null!;
}
