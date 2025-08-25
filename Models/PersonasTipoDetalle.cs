using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersonasTipoDetalle
{
    public int TipoDetalleId { get; set; }

    public int PersonaId { get; set; }

    public byte TipoPersonaId { get; set; }

    public int? TablaId { get; set; }

    public bool Anulado { get; set; }

    public virtual Personas Persona { get; set; } = null!;

    public virtual PersonaTipo TipoPersona { get; set; } = null!;
}
