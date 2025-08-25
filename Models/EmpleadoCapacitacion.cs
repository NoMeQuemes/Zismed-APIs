using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadoCapacitacion
{
    public int EmpleadoCapacitacionId { get; set; }

    public int EmpleadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? EntidadOtorgante { get; set; }

    public int? CantidadHoras { get; set; }

    public DateOnly Fecha { get; set; }

    public bool Anulado { get; set; }

    public int? TipoCapacitacionId { get; set; }

    public int? EntidadOtorganteId { get; set; }

    public string? UsuarioCarga { get; set; }

    public DateTime? FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public int? DdjjempleadoId { get; set; }

    public virtual EmpleadosHospital Empleado { get; set; } = null!;
}
