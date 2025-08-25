using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Barrios
{
    public int BarrioId { get; set; }

    public int LocalidadId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Localidades Localidad { get; set; } = null!;
}
