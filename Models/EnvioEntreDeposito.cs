using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EnvioEntreDeposito
{
    public int EnvioEntreDepositoId { get; set; }

    public int? TipoEstadoEnvioDepositoId { get; set; }

    public int? DepositoOrigenId { get; set; }

    public int? DepositoDestinoId { get; set; }

    public string? NumeroEnvio { get; set; }

    public DateTime? FechaRecibe { get; set; }

    public string? UsuarioRecibe { get; set; }

    public bool Anulado { get; set; }
}
