using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PracticasEstados
{
    public int PracticaEstadoId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }
}
