using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class VwPlanillaTurnos
{
    public int ServicioId { get; set; }

    public string Servicio { get; set; } = null!;

    public int PrestadorId { get; set; }

    public string Prestador { get; set; } = null!;

    public int ConsultorioId { get; set; }

    public string Consultorio { get; set; } = null!;

    public DateOnly? Fecha { get; set; }

    public int? Cantidad { get; set; }
}
