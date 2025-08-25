using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HistorialdeActualizacionInternaciones
{
    public int HistorialdeActualizacionInternacion { get; set; }

    public string? Detalle { get; set; }

    public string? Tabla { get; set; }

    public int? RegistroId { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? SinValidacion { get; set; }

    public bool Anulado { get; set; }
}
