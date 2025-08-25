using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnemnesisPuerperio
{
    public int AnemnesisPuerperioId { get; set; }

    public int AnaemnesisGeneralId { get; set; }

    public string? Diuresis { get; set; }

    public string? Catarsis { get; set; }

    public bool? EliminaGases { get; set; }

    public string? Rha { get; set; }

    public string? Responsable { get; set; }

    public string? Hora { get; set; }

    public string? RetraccionUterina { get; set; }

    public string? Mamas { get; set; }

    public string Loquios { get; set; } = null!;

    public string? HeridaPerineal { get; set; }

    public string? RecienNacido { get; set; }

    public string? Lactancia { get; set; }

    public DateOnly? EgresoHospital { get; set; }

    public string? EgresoHora { get; set; }

    public string? Observaciones { get; set; }

    public int? DiagnosticoPrincipal { get; set; }

    public int? DiagnosticoSecundario { get; set; }

    public string? ResponsableEgreso { get; set; }

    public int? TransferidoA { get; set; }

    public virtual AnaemnesisGeneral AnaemnesisGeneral { get; set; } = null!;

    public virtual Cie10? DiagnosticoPrincipalNavigation { get; set; }

    public virtual Cie10? DiagnosticoSecundarioNavigation { get; set; }

    public virtual OtrosCentros? TransferidoANavigation { get; set; }
}
