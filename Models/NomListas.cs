using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomListas
{
    public int NomListaId { get; set; }

    public string? Cod { get; set; }

    public string? Nombre { get; set; }

    public int NomencladorId { get; set; }

    public bool Anulado { get; set; }
}
