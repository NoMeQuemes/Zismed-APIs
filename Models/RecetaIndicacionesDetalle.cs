using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RecetaIndicacionesDetalle
{
    public int IdDetalleReceta { get; set; }

    public int IdReceta { get; set; }

    public string? Codigobarra { get; set; }

    public string? Troquel { get; set; }

    public string? IndicacionGral { get; set; }

    public DateTime FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public int? Tablaindicacionesid { get; set; }

    public string? NombreMedicamento { get; set; }

    public virtual RecetaIndicaciones IdRecetaNavigation { get; set; } = null!;

    public virtual ICollection<RecetaIndicacionesTurno> RecetaIndicacionesTurno { get; set; } = new List<RecetaIndicacionesTurno>();
}
