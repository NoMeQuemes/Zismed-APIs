using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Contactos
{
    public int ContactoId { get; set; }

    public int PersonaId { get; set; }

    public int? TipoContactoId { get; set; }

    public int PersonaContactoId { get; set; }

    public string NombreContacto { get; set; } = null!;

    public string TelefonoContacto { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Personas Persona { get; set; } = null!;

    public virtual TipoContactos? TipoContacto { get; set; }
}
