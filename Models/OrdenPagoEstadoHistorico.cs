using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenPagoEstadoHistorico
{
    public int OrdenPagoEstadoHistoricoId { get; set; }

    public int OrdenPagoId { get; set; }

    public int OrdenPagoEstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual OrdenPago OrdenPago { get; set; } = null!;

    public virtual OrdenPagoEstado OrdenPagoEstado { get; set; } = null!;
}
