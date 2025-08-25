using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EntidadesCapacitadoras
{
    public int EntidadCapacitadoraId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Detalle { get; set; }

    public string? Direccion { get; set; }

    public string? TelefonoFijo { get; set; }

    public string? TelefonoCelular { get; set; }

    public string? Email { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnulaId { get; set; }
}
