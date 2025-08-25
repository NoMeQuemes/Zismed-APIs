using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnamnesisRecienNacido
{
    public int AnamnesisRnid { get; set; }

    public int? EmpleadoId { get; set; }

    public int PacienteId { get; set; }

    public int PrestadorId { get; set; }

    public int? MedicacionPacienteId { get; set; }

    public int Peso { get; set; }

    public decimal Talla { get; set; }

    public DateTime FechaHora { get; set; }

    public decimal? PerCefalico { get; set; }

    public int? DispOxigenoId { get; set; }

    public int? EdadGestCorregida { get; set; }

    public int? EdadGestacional { get; set; }

    public string? TipoParto { get; set; }

    public bool? Rcp { get; set; }

    public bool? VacunaHepatitis { get; set; }

    public string? Lactancia { get; set; }

    public int? DiagnosticosConsultasId { get; set; }

    public string? ObservacionMedica { get; set; }

    public string? Observaciones { get; set; }

    public DateTime FechaCrea { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public bool Anulado { get; set; }

    public bool? Vitamina { get; set; }

    public int? InstitucionId { get; set; }

    public int? EmfermeroId { get; set; }
}
