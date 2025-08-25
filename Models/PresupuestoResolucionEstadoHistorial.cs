using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoResolucionEstadoHistorial
{
    public int PresupuestoResolucionEstadoHistorialId { get; set; }

    public int PresupuestoResolucionId { get; set; }

    public int PresupuestoResolucionEstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual PresupuestoResolucion PresupuestoResolucion { get; set; } = null!;

    public virtual PresupuestoResolucionEstado PresupuestoResolucionEstado { get; set; } = null!;
}
