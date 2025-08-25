using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Nodolocalidades
{
    public int LocalidadId { get; set; }

    public int DepartamentoId { get; set; }

    public string Nombre { get; set; } = null!;
}
