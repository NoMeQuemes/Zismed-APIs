using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaEnvioDeposito
{
    public int FarmaciaEnvioDepositoId { get; set; }

    public int FarTipoEstadoEnvioDepositoId { get; set; }

    public int FarmaciaDepositoOrigenId { get; set; }

    public int FarmaciaDepositoDestinoId { get; set; }

    public string? NumeroEnvio { get; set; }

    public bool PresentaFaltantes { get; set; }

    public DateTime? FechaRecibe { get; set; }

    public string? UsuarioRecibe { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual FarTipoEstadoEnvioDeposito FarTipoEstadoEnvioDeposito { get; set; } = null!;

    public virtual FarmaciaDeposito FarmaciaDepositoDestino { get; set; } = null!;

    public virtual FarmaciaDeposito FarmaciaDepositoOrigen { get; set; } = null!;

    public virtual ICollection<FarmaciaEnvioDepositoDetalle> FarmaciaEnvioDepositoDetalle { get; set; } = new List<FarmaciaEnvioDepositoDetalle>();
}
