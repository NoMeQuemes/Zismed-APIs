using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class News
{
    public int NewsId { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Detalle { get; set; }

    public string? Enlace { get; set; }

    public DateTime Inicio { get; set; }

    public DateTime Vencimiento { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public int? DiasNotificacion { get; set; }

    public int? ColorId { get; set; }

    public int? IconoId { get; set; }
}
