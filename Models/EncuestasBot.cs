using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EncuestasBot
{
    public int IdEncuesta { get; set; }

    public bool Realizada { get; set; }

    public int InstitucionId { get; set; }

    public string Usuario { get; set; } = null!;

    public DateOnly? Fecha { get; set; }
}
