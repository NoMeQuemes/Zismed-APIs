using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AfectacionesXresolucion
{
    public int AfectacionesXresolucionId { get; set; }

    public int PresupuestoAnualAfectacionId { get; set; }

    public int PresupuestoResolucionId { get; set; }

    public virtual PresupuestoAnualAfectacion PresupuestoAnualAfectacion { get; set; } = null!;

    public virtual PresupuestoResolucion PresupuestoResolucion { get; set; } = null!;
}
