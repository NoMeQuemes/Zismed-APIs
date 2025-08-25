using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HistorialCama
{
    public int HistorialCamaId { get; set; }

    public int CamaId { get; set; }

    public int HabitacionId { get; set; }

    public int EstadoCama { get; set; }

    public bool Activo { get; set; }

    public bool Anulado { get; set; }

    public int? MovimientoInternadoId { get; set; }

    public DateTime FechaMovimiento { get; set; }
}
