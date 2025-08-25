using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class IndicacionesDieta
{
    public int IndicacionesDietaId { get; set; }

    public int TipoDietaId { get; set; }

    public string? Observaciones { get; set; }

    public int PacienteId { get; set; }

    public int PrestadorId { get; set; }

    public DateTime FechaIndica { get; set; }

    public DateTime? FechaRetira { get; set; }

    public virtual ICollection<IndicacionesRegistroAplicacion> IndicacionesRegistroAplicacion { get; set; } = new List<IndicacionesRegistroAplicacion>();

    public virtual Pacientes Paciente { get; set; } = null!;

    public virtual Prestadores Prestador { get; set; } = null!;

    public virtual TipoDieta TipoDieta { get; set; } = null!;
}
