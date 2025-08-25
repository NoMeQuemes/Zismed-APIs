using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaTipoIngreso
{
    public int GuardiaTipoIngresoId { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<GuardiaRegistro> GuardiaRegistro { get; set; } = new List<GuardiaRegistro>();
}
