using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoControlesDiarios
{
    public int IdControlDiario { get; set; }

    public int IdIngresoNodo { get; set; }

    public int IdPaciente { get; set; }

    public DateOnly FechaControl { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Talla { get; set; }

    public decimal? PerimetroAbdominal { get; set; }

    public decimal? Imc { get; set; }

    public string? SignosVitalesTa { get; set; }

    public bool? Pamayor9060 { get; set; }

    public decimal? SignosVitalesTemp { get; set; }

    public bool? TempMayorIgual375 { get; set; }

    public string? SignosVitalesFc { get; set; }

    public string? SignosVitalesFr { get; set; }

    public bool? FrmayorIgual30x { get; set; }

    public string? SignosVitalesSatu { get; set; }

    public bool? SaturometriaMenor92 { get; set; }

    public int? DificultadRespiratoria { get; set; }

    public string? Drotro { get; set; }

    public int? ComunicaMedico { get; set; }

    public string? AplicacionTratamiento { get; set; }

    public string? Observaciones { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public virtual NodoIngreso IdIngresoNodoNavigation { get; set; } = null!;
}
