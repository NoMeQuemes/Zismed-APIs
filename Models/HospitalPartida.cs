using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HospitalPartida
{
    public int HospitalPartidaId { get; set; }

    public int HospitalActividadId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public virtual HospitalActividad HospitalActividad { get; set; } = null!;

    public virtual ICollection<PresupuestoAnualDetalle> PresupuestoAnualDetalle { get; set; } = new List<PresupuestoAnualDetalle>();
}
