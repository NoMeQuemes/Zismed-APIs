using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Profesion
{
    public int ProfesionId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }
}
