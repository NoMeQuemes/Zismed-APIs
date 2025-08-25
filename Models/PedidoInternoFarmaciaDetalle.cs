using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoInternoFarmaciaDetalle
{
    public int PedidoInternoFarmaciaDetalleId { get; set; }

    public int PedidoInternoFarmaciaId { get; set; }

    public int MedicamentoId { get; set; }

    public decimal Cantidad { get; set; }

    public DateOnly Fecha { get; set; }

    public DateTime FechaCrea { get; set; }

    public string OpCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? PedIntEstadoId { get; set; }

    public decimal? CantidadSaldo { get; set; }
}
