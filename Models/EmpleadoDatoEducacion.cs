using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EmpleadoDatoEducacion
{
    public int EmpleadoDatoEducacionId { get; set; }

    public int? EmpleadoId { get; set; }

    public int TipoInstruccionId { get; set; }

    public int ProfesionId { get; set; }

    public int TituloId { get; set; }

    public int? EspecialidadId { get; set; }

    public string? NroMatriculaProfesional { get; set; }

    public bool Anulado { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public int? DdjjempleadoId { get; set; }
}
