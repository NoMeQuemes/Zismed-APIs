using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Hcsnomed
{
    public int IdTerminoSnomed { get; set; }

    public int? IdConsulta { get; set; }

    public int Tipo { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int IdConceptSnomed { get; set; }

    public virtual ConsultasAmbulatorias? IdConsultaNavigation { get; set; }
}
