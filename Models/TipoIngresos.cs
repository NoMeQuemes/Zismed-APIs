using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoIngresos
{
    public int TipoIngresoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<Internaciones> Internaciones { get; set; } = new List<Internaciones>();
}
