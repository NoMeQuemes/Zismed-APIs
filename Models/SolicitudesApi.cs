using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class SolicitudesApi
{
    public int ApiSolicitudId { get; set; }

    public DateTime FechaSolicitud { get; set; }

    public string Endpoint { get; set; } = null!;

    public string? DatosEnviados { get; set; }

    public int? StatusCode { get; set; }

    public DateTime? FechaRespuesta { get; set; }

    public string? DatosRecibidos { get; set; }

    public string? Message { get; set; }

    public bool? Error { get; set; }

    public string? Usuario { get; set; }

    public int? InstitucionId { get; set; }
}
