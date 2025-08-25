using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenPagoRetenciones
{
    public int OrdenPagoRetencionesId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<OrdenPagoDetalle> OrdenPagoDetalle { get; set; } = new List<OrdenPagoDetalle>();
}
