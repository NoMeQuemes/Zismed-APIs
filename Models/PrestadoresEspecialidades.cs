using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrestadoresEspecialidades
{
    public int IdPrestadorEspecialidad { get; set; }

    public int PrestadorId { get; set; }

    public int EspecialidadId { get; set; }

    public string? Documento { get; set; }

    public bool Anulado { get; set; }

    public string? UserAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public virtual Especialidades Especialidad { get; set; } = null!;
}
