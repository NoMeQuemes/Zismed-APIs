using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoTelefonos
{
    public int TipoTelefonoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<Telefonos> Telefonos { get; set; } = new List<Telefonos>();
}
