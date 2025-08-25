using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CentrosVacunacion
{
    public int CentrosVacunacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }
}
