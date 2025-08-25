using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Enfermeria
{
    public int EnfermeriaId { get; set; }

    public string? Detalle { get; set; }

    public int? EmpleadoId { get; set; }

    public int? PacienteId { get; set; }

    public int? MedicacionPacienteId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? InternacionId { get; set; }

    public int? SectorId { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public virtual MedicacionPaciente? MedicacionPaciente { get; set; }
}
