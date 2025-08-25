using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomExpDetallePagos
{
    public int NomExpDetallePagoId { get; set; }

    public decimal Monto { get; set; }

    public bool Anulado { get; set; }

    public int? LoteRegPagoId { get; set; }

    public int NomExpedienteDetalleId { get; set; }
}
