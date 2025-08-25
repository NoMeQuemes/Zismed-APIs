using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaEnvioDepositoDetalle
{
    public int FarmaciaEnvioDepositoDetalleId { get; set; }

    public int FarmaciaEnvioDepositoId { get; set; }

    public int FarTipoEstadoRecepcionDepositoId { get; set; }

    public int FarmaciaArticuloId { get; set; }

    public int? NroRegistro { get; set; }

    public string? Gtin { get; set; }

    public string? CodBarras { get; set; }

    public bool Trazado { get; set; }

    public decimal CantidadEnviada { get; set; }

    public decimal CantidadRecibida { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual FarTipoEstadoRecepcionDeposito FarTipoEstadoRecepcionDeposito { get; set; } = null!;

    public virtual ArticulosFarmaciaCis FarmaciaArticulo { get; set; } = null!;

    public virtual FarmaciaEnvioDeposito FarmaciaEnvioDeposito { get; set; } = null!;

    public virtual ICollection<FarmaciaEnvioDepositoDetalleLoteVto> FarmaciaEnvioDepositoDetalleLoteVto { get; set; } = new List<FarmaciaEnvioDepositoDetalleLoteVto>();
}
