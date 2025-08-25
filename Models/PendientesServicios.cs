using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PendientesServicios
{
    public int? PendientesServiciosId { get; set; }

    public int? SectorSolicitanteId { get; set; }

    public int? SectorEfectorId { get; set; }

    public int? PacienteId { get; set; }

    public int? PrestadorSolicitanteId { get; set; }

    public int? PrestadorEfectorId { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public string? DetallePedido { get; set; }

    public int? TurnoOrigenId { get; set; }

    public int? TurnoNuevoId { get; set; }

    public bool? Anulado { get; set; }
}
