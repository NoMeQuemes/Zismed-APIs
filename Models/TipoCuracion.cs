using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoCuracion
{
    public int TipoCuracionId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<GuardiaRegistro> GuardiaRegistro { get; set; } = new List<GuardiaRegistro>();
}
