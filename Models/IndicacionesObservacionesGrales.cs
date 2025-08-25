using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class IndicacionesObservacionesGrales
{
    public int IndicacionesObservacionesGralesId { get; set; }

    public string Observacion { get; set; } = null!;

    public int PacienteId { get; set; }

    public int PrestadorId { get; set; }

    public DateTime FechaIndica { get; set; }

    public DateTime? FechaRetira { get; set; }

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;
}
