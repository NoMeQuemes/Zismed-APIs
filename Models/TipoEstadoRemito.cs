using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoEstadoRemito
{
    public int EstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<FarRemitoTemporalEncabezado> FarRemitoTemporalEncabezado { get; set; } = new List<FarRemitoTemporalEncabezado>();
}
