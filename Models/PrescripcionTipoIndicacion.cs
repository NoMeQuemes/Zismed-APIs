using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrescripcionTipoIndicacion
{
    public int PrescripcionTipoIndicacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<PrescripcionDetalle> PrescripcionDetalle { get; set; } = new List<PrescripcionDetalle>();
}
