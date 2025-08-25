using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MotivosAnula
{
    public int MotivoAnulaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Detalle { get; set; } = null!;

    public bool Anulado { get; set; }
}
