using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoInternoFarmacia
{
    public int PedidoInternoFarmaciaId { get; set; }

    public string NumeroPedidoInterno { get; set; } = null!;

    public DateTime? FechaPedido { get; set; }

    public int SectorId { get; set; }

    public string? Motivo { get; set; }

    public string? Observaciones { get; set; }

    public DateTime FechaCrea { get; set; }

    public string OpCrea { get; set; } = null!;

    public bool? Autorizado { get; set; }

    public DateTime? FechaAutoriza { get; set; }

    public string? OpAutoriza { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string? OpModifica { get; set; }

    public int PedIntEstadoId { get; set; }

    public int? PedidoPrioridadId { get; set; }

    public bool Anulado { get; set; }

    public int? IndiacionIdhc { get; set; }

    public int? InstitucionId { get; set; }

    public int? InstitucionAnteriorId { get; set; }
}
