using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class UltimoTurnoRecomendado
{
    public int Id { get; set; }

    public int PacienteId { get; set; }

    public int PrestadorId { get; set; }

    public int? ConsultorioId { get; set; }

    public int ServicioId { get; set; }

    public int InstitucionId { get; set; }

    public DateTime Fecha { get; set; }

    public bool Confirmado { get; set; }

    public bool Anulado { get; set; }

    public DateTime? FechaModifica { get; set; }

    public int Frecuencia { get; set; }

    public int? TurnoId { get; set; }
}
