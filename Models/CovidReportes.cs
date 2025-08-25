using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CovidReportes
{
    public int IdReporte { get; set; }

    public int IdInstitucion { get; set; }

    public int IdTipoReporte { get; set; }

    public DateTime FechaEnvio { get; set; }

    public int IdReporteNacion { get; set; }

    public string Envio { get; set; } = null!;

    public string Respuesta { get; set; } = null!;
}
