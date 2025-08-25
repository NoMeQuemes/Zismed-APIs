using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoAislamiento
{
    public int IdTipoAislamiento { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int IdInstitucion { get; set; }

    public bool Anulado { get; set; }

    public string? Color { get; set; }
}
