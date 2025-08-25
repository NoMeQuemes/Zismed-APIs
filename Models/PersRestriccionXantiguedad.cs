using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersRestriccionXantiguedad
{
    public int PersRestriccionXantiguedadId { get; set; }

    public int PersTipoLicenciaId { get; set; }

    public int PersRestriccionId { get; set; }

    public int? Orden { get; set; }

    public string? Tipo { get; set; }

    public bool Anulado { get; set; }
}
