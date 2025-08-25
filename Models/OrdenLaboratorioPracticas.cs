using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenLaboratorioPracticas
{
    public int OrdenLabPracticasId { get; set; }

    public int LaboratorioPracticasId { get; set; }

    public int Orden { get; set; }

    public bool? Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateOnly? FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateOnly? FechaAnula { get; set; }
}
