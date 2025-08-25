using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GruposPersonas
{
    public int GrupoPersonaId { get; set; }

    public int GrupoId { get; set; }

    public int PersonaId { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public bool Anulado { get; set; }

    public virtual Grupos Grupo { get; set; } = null!;

    public virtual Personas Persona { get; set; } = null!;
}
