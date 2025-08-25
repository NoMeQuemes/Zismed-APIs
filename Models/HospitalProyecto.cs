using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HospitalProyecto
{
    public int HospitalProyectoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int ProyectoEstadoId { get; set; }

    public int HospitalId { get; set; }

    public virtual Hospital Hospital { get; set; } = null!;

    public virtual ICollection<PresupuestoAnualDetalle> PresupuestoAnualDetalle { get; set; } = new List<PresupuestoAnualDetalle>();

    public virtual ProyectoEstado ProyectoEstado { get; set; } = null!;
}
