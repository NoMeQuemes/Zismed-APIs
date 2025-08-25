using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Telefonos
{
    public int TelefonosId { get; set; }

    public int PersonaId { get; set; }

    public int TipoTelefonoId { get; set; }

    public string Numero { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Personas Persona { get; set; } = null!;

    public virtual TipoTelefonos TipoTelefono { get; set; } = null!;
}
