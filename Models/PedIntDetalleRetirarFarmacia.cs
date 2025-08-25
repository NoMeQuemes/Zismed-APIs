using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedIntDetalleRetirarFarmacia
{
    public int PedIntDetalleRetirarId { get; set; }

    public int PedidoInternoFarmaciaDetalleId { get; set; }

    public decimal CantAretirar { get; set; }

    public int PedIntEstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public int DepositoId { get; set; }
}
