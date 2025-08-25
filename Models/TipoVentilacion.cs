using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoVentilacion
{
    public int TipoVentilacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<IndicacionesVentilacionMecanica> IndicacionesVentilacionMecanica { get; set; } = new List<IndicacionesVentilacionMecanica>();
}
