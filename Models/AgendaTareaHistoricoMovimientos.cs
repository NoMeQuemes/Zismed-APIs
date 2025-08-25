using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AgendaTareaHistoricoMovimientos
{
    public int IdAgendaHistoricoMov { get; set; }

    public int IdAgendaTarea { get; set; }

    public string EstadoAnterior { get; set; } = null!;

    public string EstadoNuevo { get; set; } = null!;

    public DateTime FechaCambio { get; set; }

    public string OpCambio { get; set; } = null!;
}
