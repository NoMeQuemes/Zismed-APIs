using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RecetaIndicacionesTurno
{
    public int IdRecetaIndicacionesTurno { get; set; }

    public int IdDetalleReceta { get; set; }

    public int IdTurnoReceta { get; set; }

    public string Dosis { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public virtual RecetaIndicacionesDetalle IdDetalleRecetaNavigation { get; set; } = null!;
}
