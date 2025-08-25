using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenPagoEstado
{
    public int OrdenPagoEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descipcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<OrdenPago> OrdenPago { get; set; } = new List<OrdenPago>();

    public virtual ICollection<OrdenPagoEstadoHistorico> OrdenPagoEstadoHistorico { get; set; } = new List<OrdenPagoEstadoHistorico>();
}
