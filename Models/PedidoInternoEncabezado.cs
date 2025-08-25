using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoInternoEncabezado
{
    public int PedidoInternoEncabezadoId { get; set; }

    public string NumeroPedidoInterno { get; set; } = null!;

    public string Anio { get; set; } = null!;

    public int TipoPedidoInternoId { get; set; }

    public string RemitoProveedor { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public decimal EstimativoTotal { get; set; }

    public string Observaciones { get; set; } = null!;

    public int SolicitaSectorId { get; set; }

    public int DestinoSectorId { get; set; }

    public bool Anulado { get; set; }

    public DateTime FechaCrea { get; set; }

    public string OpCrea { get; set; } = null!;

    public DateTime? FechaModi { get; set; }

    public string? OpModi { get; set; }

    public virtual SectoresHospital DestinoSector { get; set; } = null!;

    public virtual SectoresHospital SolicitaSector { get; set; } = null!;

    public virtual TipoPedidoInterno TipoPedidoInterno { get; set; } = null!;
}
