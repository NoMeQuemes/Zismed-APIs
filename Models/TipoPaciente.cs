using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoPaciente
{
    public int TipoPacienteId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? InstitucionId { get; set; }

    public int? EdadDesde { get; set; }

    public int? EdadHasta { get; set; }

    public int? TipoEdad { get; set; }

    public bool? Edad { get; set; }
}
