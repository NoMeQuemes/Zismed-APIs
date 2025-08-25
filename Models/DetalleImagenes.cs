using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DetalleImagenes
{
    public int DetalleImagenesId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AdmisionImagenes> AdmisionImagenes { get; set; } = new List<AdmisionImagenes>();
}
