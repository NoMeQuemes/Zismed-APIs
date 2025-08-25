using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Intumizacion
{
    public int IntumizacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<EmpleadoIntumizacion> EmpleadoIntumizacion { get; set; } = new List<EmpleadoIntumizacion>();
}
