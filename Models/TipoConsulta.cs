using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoConsulta
{
    public int TipoConsultaId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }
}
