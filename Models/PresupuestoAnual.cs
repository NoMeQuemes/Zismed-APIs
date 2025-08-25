using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoAnual
{
    public int PresupuestoAnualId { get; set; }

    public string Anio { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public int HospitalId { get; set; }

    public bool Vencido { get; set; }

    public string? UsuarioVence { get; set; }

    public DateTime? FechaVence { get; set; }

    public int? ExpedienteId { get; set; }

    public virtual Hospital Hospital { get; set; } = null!;

    public virtual ICollection<PresupuestoAnualDetalle> PresupuestoAnualDetalle { get; set; } = new List<PresupuestoAnualDetalle>();
}
