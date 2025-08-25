using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AdmisionLaboratorio
{
    public int AdmisionLaboratorioId { get; set; }

    public int TurnoId { get; set; }

    public string NumeroProtocolo { get; set; } = null!;

    public int DetalleLaboratorioId { get; set; }

    public DateOnly? TomaMuestra { get; set; }

    public string? HoraTomaMuestra { get; set; }

    public string? Tomadapor { get; set; }

    public bool Anulado { get; set; }

    public virtual PerfilDetalleLaboratorio DetalleLaboratorio { get; set; } = null!;

    public virtual Turnos Turno { get; set; } = null!;
}
