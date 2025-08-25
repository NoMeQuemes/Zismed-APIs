using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoDiscapacidad
{
    public int TipoDiscapacidadId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnulaId { get; set; }
}
