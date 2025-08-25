using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomCatLaboratorio
{
    public int NomCatLaboratorioId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public string? Codigo { get; set; }
}
