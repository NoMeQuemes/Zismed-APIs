using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PedidoPrioridad
{
    public int PedidoPrioridadId { get; set; }

    public string Nombre { get; set; } = null!;

    public int Numero { get; set; }

    public string Color { get; set; } = null!;

    public bool Anulado { get; set; }
}
