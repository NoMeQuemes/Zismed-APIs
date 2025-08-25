using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrestadoresInstituciones
{
    public int PrestadoresInstitucionesId { get; set; }

    public int PrestadorId { get; set; }

    public int InstitucionId { get; set; }

    public bool Anulado { get; set; }

    public string? OpCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? OpAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public bool? OrdenAtencionTurno { get; set; }
}
