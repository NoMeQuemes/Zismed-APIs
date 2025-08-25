using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Departamentos
{
    public int DepartamentoId { get; set; }

    public string Nombre { get; set; } = null!;

    public int ProvinciaId { get; set; }
}
