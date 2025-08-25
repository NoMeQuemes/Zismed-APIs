using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AsistenciaMedicos
{
    public int AsistenciaMedicoId { get; set; }

    public int? PrestadorId { get; set; }

    public DateOnly? Fecha { get; set; }

    public bool Coordinador { get; set; }

    public bool Anulado { get; set; }

    public virtual Prestadores? Prestador { get; set; }
}
