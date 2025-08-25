using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrientacionObstetrica
{
    public int OrientacionObstetricaId { get; set; }

    public int PacienteId { get; set; }

    public int OrientacionDerivaId { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual OrientacionDeriva OrientacionDeriva { get; set; } = null!;

    public virtual Pacientes Paciente { get; set; } = null!;
}
