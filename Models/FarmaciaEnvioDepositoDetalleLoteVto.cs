using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaEnvioDepositoDetalleLoteVto
{
    public int FarmaciaEnvioDepositoDetalleLoteVtoId { get; set; }

    public int FarmaciaEnvioDepositoDetalleId { get; set; }

    public int FarmaciaArticuloId { get; set; }

    public DateOnly? Vencimiento { get; set; }

    public string? Lote { get; set; }

    public decimal CantidadEnviada { get; set; }

    public decimal CantidadRecibida { get; set; }

    public bool Anulado { get; set; }

    public virtual ArticulosFarmaciaCis FarmaciaArticulo { get; set; } = null!;

    public virtual FarmaciaEnvioDepositoDetalle FarmaciaEnvioDepositoDetalle { get; set; } = null!;
}
