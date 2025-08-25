using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadoIntumizacion
{
    public int EmpleadoIntumizacionId { get; set; }

    public int IntumizacionId { get; set; }

    public DateTime? FechaColocacion { get; set; }

    public int EmpleadoId { get; set; }

    public DateTime FechaCarga { get; set; }

    public string? UsuarioCarga { get; set; }

    public bool Anulado { get; set; }

    public int? DdjjempleadoId { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public virtual EmpleadosHospital Empleado { get; set; } = null!;

    public virtual Intumizacion Intumizacion { get; set; } = null!;
}
