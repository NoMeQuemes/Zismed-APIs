using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoDomicilio
{
    public int TipodomicilioId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<Domicilios> Domicilios { get; set; } = new List<Domicilios>();
}
