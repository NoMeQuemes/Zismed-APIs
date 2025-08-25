using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TituloProfesional
{
    public int TituloProfesionalId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }
}
