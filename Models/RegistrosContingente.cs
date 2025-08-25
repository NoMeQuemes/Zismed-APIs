using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RegistrosContingente
{
    public int RegistroContingenteId { get; set; }

    public string NroPatente { get; set; } = null!;

    public int? EmpresaColectivoId { get; set; }

    public int ProvinciaOrigenId { get; set; }

    public DateTime FechaSalida { get; set; }

    public DateTime FechaArribo { get; set; }

    public int CantPersonas { get; set; }

    public int CantPersCargada { get; set; }

    public string? Observaciones { get; set; }

    public bool ConfirmarArribo { get; set; }

    public DateTime? FechaConfirmaArribo { get; set; }

    public string? UsuarioConfirma { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnulaId { get; set; }

    public string? ObservacionAnula { get; set; }

    public int? TipoVehiculoId { get; set; }

    public int? InstitucionId { get; set; }
}
