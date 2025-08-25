using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Consulta
{
    public int Id { get; set; }

    public int? PacienteId { get; set; }

    public string? Documento { get; set; }

    public string? DocReferencia { get; set; }

    public string? Sexo { get; set; }

    public int? Edad { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Diagnostico { get; set; }

    public string? Presuntivo { get; set; }

    public string? Evolucion { get; set; }

    public decimal? Peso { get; set; }

    public int? Talla { get; set; }

    public decimal? PerimetroCef { get; set; }

    public string? Servicio { get; set; }

    public int? EdadDias { get; set; }

    public DateTime? FechaNac { get; set; }
}
