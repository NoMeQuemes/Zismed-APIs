using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoInterno
{
    public int PedidoInternoId { get; set; }

    public string NumeroPedidoInterno { get; set; } = null!;

    public string Anio { get; set; } = null!;

    public int? TipoPedidoInternoId { get; set; }

    public string? RemitoProveedor { get; set; }

    public DateOnly Fecha { get; set; }

    public decimal? EstimativoTotal { get; set; }

    public string? Observaciones { get; set; }

    public int? PedidoSectorIdsolicita { get; set; }

    public int? DestinoSectorId { get; set; }

    public DateTime FechaCrea { get; set; }

    public string OpCrea { get; set; } = null!;

    public DateTime? FechaModi { get; set; }

    public string? OpModi { get; set; }

    public int? PedidoLugarEntregaId { get; set; }

    public string? MotivoPedido { get; set; }

    public string? DirigidoA { get; set; }

    public int? DepositoServicioId { get; set; }

    public bool Anulado { get; set; }

    public bool? Autorizado { get; set; }

    public string? UsuarioAutoriza { get; set; }

    public DateTime? FechaAutoriza { get; set; }

    public int? PedidoPrioridadId { get; set; }

    public int? PedIntEstadoId { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<PedidoInternoDestinos> PedidoInternoDestinos { get; set; } = new List<PedidoInternoDestinos>();

    public virtual ICollection<PedidoInternoDetalle> PedidoInternoDetalle { get; set; } = new List<PedidoInternoDetalle>();
}
