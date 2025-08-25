using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PacienteSitSocioEconomica
{
    public int PacienteSitSocioEconomicaId { get; set; }

    public int PacienteId { get; set; }

    public string? Solo { get; set; }

    public string? ParteFliaConv { get; set; }

    public string? TodaFliaConv { get; set; }

    public string? AmigosCompanieros { get; set; }

    public string? IngresoOtro { get; set; }

    public string? DomNo { get; set; }

    public string? DomSi { get; set; }

    public string? DomNsnc { get; set; }

    public string? DomOtro { get; set; }

    public string? Calle { get; set; }

    public string? Numero { get; set; }

    public string? Barrio { get; set; }

    public int? ProvinciaId { get; set; }

    public int? DepartamentoId { get; set; }

    public int? LocalidadId { get; set; }

    public string? Casa { get; set; }

    public string? Departamento { get; set; }

    public string? TipoRancho { get; set; }

    public string? Inquilinto { get; set; }

    public string? TipoViviendaOtro { get; set; }

    public int? CantPersParaAsilamiento { get; set; }

    public string? Embarazada { get; set; }

    public string? Comorbilidades { get; set; }

    public string? Mayores60 { get; set; }

    public string? ConvivienteOtro { get; set; }

    public int? CantHabitaciones { get; set; }

    public int? CantBaniosInstalados { get; set; }

    public string? ObservacionesSe { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
