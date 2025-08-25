using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LoteRegPagos
{
    public int LoteRegPagoId { get; set; }

    public int TipoPagoId { get; set; }

    public bool Anulado { get; set; }

    public int? LoteId { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public decimal? Monto { get; set; }

    public string? Observacion { get; set; }

    public DateTime? Distribuido { get; set; }

    public string? UsuarioMarcaDistribuido { get; set; }
}
