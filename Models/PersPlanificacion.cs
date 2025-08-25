using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersPlanificacion
{
    public int PersPlanificacionId { get; set; }

    public int EmpleadoId { get; set; }

    public string Periodo { get; set; } = null!;

    public DateOnly FechaCierre { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual EmpleadosHospital Empleado { get; set; } = null!;

    public virtual ICollection<PersPlanificacionDetalle> PersPlanificacionDetalle { get; set; } = new List<PersPlanificacionDetalle>();
}
