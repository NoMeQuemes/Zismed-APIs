using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersonaTipo
{
    public byte TipoPersonaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Tabla { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<PersonasTipoDetalle> PersonasTipoDetalle { get; set; } = new List<PersonasTipoDetalle>();
}
