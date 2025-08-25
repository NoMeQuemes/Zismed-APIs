using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RegistroPedidosPendientes
{
    public int RegistroPedidosPendientesId { get; set; }

    public int OrigenPedidoId { get; set; }

    public int OrigenRegistroId { get; set; }

    public int DestinoPedidoId { get; set; }

    public int? DestinoRegistroId { get; set; }

    public string? Observaciones { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAplica { get; set; }

    public DateTime? FechaAplica { get; set; }

    public int PacienteId { get; set; }

    public int? InstitucionId { get; set; }

    public int? HabitacionId { get; set; }
}
