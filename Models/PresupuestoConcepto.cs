using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoConcepto
{
    public int PresupuestoConceptoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<PresupuestoAnualMovimiento> PresupuestoAnualMovimiento { get; set; } = new List<PresupuestoAnualMovimiento>();
}
