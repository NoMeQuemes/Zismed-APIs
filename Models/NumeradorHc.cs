using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NumeradorHc
{
    public int NumeradorId { get; set; }

    public int PacienteId { get; set; }

    public string Numero { get; set; } = null!;

    public DateTime? FechaCrea { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual Pacientes Paciente { get; set; } = null!;
}
