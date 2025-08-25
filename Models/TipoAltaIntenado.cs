using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoAltaIntenado
{
    public int TipoAltaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? TipoAltaIosepId { get; set; }

    public virtual ICollection<GuardiaRegistro> GuardiaRegistro { get; set; } = new List<GuardiaRegistro>();

    public virtual ICollection<Internaciones> Internaciones { get; set; } = new List<Internaciones>();
}
