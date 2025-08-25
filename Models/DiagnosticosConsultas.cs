using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DiagnosticosConsultas
{
    public int DiagnosticosConsultasId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public bool Enfermeria { get; set; }

    public bool? Informar { get; set; }

    public int? Prioridad { get; set; }

    public int? DiagnosticosConsultasIdoriginal { get; set; }

    public virtual ICollection<ConsultasAmbulatorias> ConsultasAmbulatorias { get; set; } = new List<ConsultasAmbulatorias>();
}
