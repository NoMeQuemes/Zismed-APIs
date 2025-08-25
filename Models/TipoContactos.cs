using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoContactos
{
    public int TipoContactoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<Contactos> Contactos { get; set; } = new List<Contactos>();
}
