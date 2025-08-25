using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoDietas
{
    public int NodoDietaId { get; set; }

    public int IdIngresoNodo { get; set; }

    public int? DietaId { get; set; }

    public string? Detalle { get; set; }

    public DateTime FechaCarga { get; set; }

    public string? UsuarioCarga { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public int? IdMovimiento { get; set; }
}
