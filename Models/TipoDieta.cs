using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoDieta
{
    public int TipoDietaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public bool EsVia { get; set; }

    public virtual ICollection<IndicacionesDieta> IndicacionesDieta { get; set; } = new List<IndicacionesDieta>();
}
