using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ObservacionesVarias
{
    public int ObservacionesVariasId { get; set; }

    public string Observacion { get; set; } = null!;

    public int PacienteId { get; set; }

    public int EmpleadoId { get; set; }

    public int? TurnoId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public int? GuardiaSectorId { get; set; }

    public DateTime FechaCarga { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public bool Anulado { get; set; }
}
