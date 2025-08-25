using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class IosepDatosIngreso
{
    public int IosepDatoaIngresoId { get; set; }

    public int IdAdmision { get; set; }

    public int IdPaciente { get; set; }

    public int InstitucionId { get; set; }

    public decimal? Temperatura { get; set; }

    public decimal? TensionArterial { get; set; }

    public decimal? FrecuenciaCardiaca { get; set; }

    public decimal? FrecuenciaRespiratoria { get; set; }

    public decimal? Saturacion { get; set; }

    public string? TestOlfato { get; set; }

    public int? Fiebre { get; set; }

    public int? Tos { get; set; }

    public int? FaltaAire { get; set; }

    public int? Odinofagia { get; set; }

    public int? Disgeusia { get; set; }

    public int? Mialgias { get; set; }

    public int? Cefalea { get; set; }

    public int? PerdidaGusto { get; set; }

    public int? PerdidaOlfato { get; set; }

    public int? Diarrea { get; set; }

    public int? Vomito { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
