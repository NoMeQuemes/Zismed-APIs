using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoVehiculo
{
    public int TipoVehiculoId { get; set; }

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnula { get; set; }
}
