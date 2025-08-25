using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EnvioEntreDepositoDetalle
{
    public int EnvioEntreDepositoDetalleId { get; set; }

    public int? EnvioEntreDepositoId { get; set; }

    public int? FarTipoEstadoRecepcionDepositoId { get; set; }

    public int? ProductoId { get; set; }

    public int? CantidadEnviada { get; set; }

    public int? CantidadRecibida { get; set; }

    public DateTime? FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string? UsuarioCrea { get; set; }

    public string? UsuarioModifica { get; set; }

    public bool Anulado { get; set; }
}
