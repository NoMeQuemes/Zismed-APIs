using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaAnamnesis
{
    public int GuardiaAnamnesisId { get; set; }

    public int GuardiaRegistroId { get; set; }

    public int GuardiaSectorId { get; set; }

    public int GuardiaTipoCuestionarioId { get; set; }

    public int? PrestadorId { get; set; }

    public int? EmpleadoId { get; set; }

    public DateTime FechaAnamneisis { get; set; }

    public DateTime FechaCrea { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? EmfermeroId { get; set; }

    public virtual GuardiaRegistro GuardiaRegistro { get; set; } = null!;

    public virtual GuardiaTipoCuestionario GuardiaTipoCuestionario { get; set; } = null!;

    public virtual Prestadores? Prestador { get; set; }
}
