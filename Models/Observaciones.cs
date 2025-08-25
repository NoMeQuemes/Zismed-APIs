using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Observaciones
{
    public int ObservacionesId { get; set; }

    public int PersonaId { get; set; }

    public DateTime Fecha { get; set; }

    public string Observacion { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Personas Persona { get; set; } = null!;
}
