using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnaemnesisReducida
{
    public int AnaemnesisReducidaId { get; set; }

    public int PacienteId { get; set; }

    public int? TurnoId { get; set; }

    public int? InternacionId { get; set; }

    public int? GuardiaRegistroId { get; set; }

    public int? GuardiaSectorId { get; set; }

    public int? ShockRoomRegistroId { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Temperatura { get; set; }

    public int? Pulso { get; set; }

    public int? TensionArterialMaxima { get; set; }

    public int? TensionArterialMinima { get; set; }

    public int? Talla { get; set; }

    public int? FrecuenciaRespiratoria { get; set; }

    public int? FrecuenciaCardiaca { get; set; }

    public int? EdadGestacional { get; set; }

    public decimal? PerimetroCefalico { get; set; }

    public decimal? MasaCorporal { get; set; }

    public decimal? Percentil { get; set; }

    public DateOnly? FechaPrimeraIngesta { get; set; }

    public string? AntecedentesMadre { get; set; }

    public int? Saturacion { get; set; }

    public int? Glucemia { get; set; }

    public decimal? ScoreTal { get; set; }

    public int? Glasgow { get; set; }

    public DateTime FechaCrea { get; set; }

    public string Usuario { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public bool? Fumador { get; set; }

    public string? Evolucion { get; set; }

    public int? EmfermeroId { get; set; }

    public string? Observaciones { get; set; }

    public byte? AntecFamDiabetes { get; set; }

    public bool? EjercicioDiario { get; set; }

    public bool? ComeFrutasVerdurasDiario { get; set; }

    public bool? MedicadoHipertension { get; set; }

    public bool? PerimetroCintura { get; set; }

    public bool? TuvoHiperglucemia { get; set; }

    public int? PerimetroCinturares { get; set; }

    public decimal? CircunferenciaCintura { get; set; }

    public virtual Internaciones? Internacion { get; set; }
}
