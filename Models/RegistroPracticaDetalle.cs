using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RegistroPracticaDetalle
{
    public int RegistroPracticaDetId { get; set; }

    public int RegistroPracticaId { get; set; }

    public int? PracticaId { get; set; }

    public int? Cantidad { get; set; }

    public bool Anulado { get; set; }

    public int? EstadoPractica { get; set; }

    public string? Nombre { get; set; }

    public string? Codigo { get; set; }
}
