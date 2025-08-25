using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EpicrisisPendiente
{
    public int EpicrisisPendienteId { get; set; }

    public int EpicrisisId { get; set; }

    public string? Tipo { get; set; }

    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public bool Anulado { get; set; }
}
