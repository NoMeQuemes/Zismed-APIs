using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoResolucionEstado
{
    public int PresupuestoResolucionEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<PresupuestoResolucion> PresupuestoResolucion { get; set; } = new List<PresupuestoResolucion>();

    public virtual ICollection<PresupuestoResolucionEstadoHistorial> PresupuestoResolucionEstadoHistorial { get; set; } = new List<PresupuestoResolucionEstadoHistorial>();
}
