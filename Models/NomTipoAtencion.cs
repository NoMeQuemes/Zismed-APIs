using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomTipoAtencion
{
    public int NomTipoAtencionId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }
}
