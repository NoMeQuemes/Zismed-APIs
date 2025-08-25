using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoDocumento
{
    public int TipoDocumentoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<Personas> Personas { get; set; } = new List<Personas>();
}
