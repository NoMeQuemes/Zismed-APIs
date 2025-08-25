using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioOperadores
{
    public int LaboratorioOperadorId { get; set; }

    public string? Nombre { get; set; }

    public string? Signo { get; set; }

    public bool Anulado { get; set; }
}
