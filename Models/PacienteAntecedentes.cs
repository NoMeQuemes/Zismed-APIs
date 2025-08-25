using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PacienteAntecedentes
{
    public int PacienteAntecedenteId { get; set; }

    public int PacienteId { get; set; }

    public string? DiabetesPers { get; set; }

    public string? DiabetesFliar { get; set; }

    public string? EpocasmaPers { get; set; }

    public string? EpocasmaFliar { get; set; }

    public string? EnfermedadRenalCronicaPers { get; set; }

    public string? EnfermedadRenalCronicaFliar { get; set; }

    public string? EnfermedadCardVascPers { get; set; }

    public string? EnfermedadCardVascFliar { get; set; }

    public string? InmunocomprometidoPers { get; set; }

    public string? InmunocomprometidoFliar { get; set; }

    public string? ObesidadMorbidaPers { get; set; }

    public string? ObesidadMorbidaFliar { get; set; }

    public string? TratamientoActual { get; set; }

    public string? TabaquismoPers { get; set; }

    public string? TabaquismoFliar { get; set; }

    public string? AlcoholismoPers { get; set; }

    public string? AlcoholismoFliar { get; set; }

    public string? RenalCronicaPers { get; set; }

    public string? RenalCronicaFliar { get; set; }

    public string? AdiccionDrogasIlicitasPers { get; set; }

    public string? AdiccionDrogasIlicitasFliar { get; set; }

    public string? AlergiasPers { get; set; }

    public string? AlergiasFliar { get; set; }

    public string? ProbPsicPsiqPers { get; set; }

    public string? ProbPsicPsiqFliar { get; set; }

    public string? ViolenciaPers { get; set; }

    public string? ViolenciaFliar { get; set; }

    public string? OtroPers { get; set; }

    public string? OtroFliar { get; set; }

    public string? TratamientoActualAnt { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }
}
