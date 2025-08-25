using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AdmisionImagenes
{
    public int AdmisionImagenesId { get; set; }

    public int TurnoId { get; set; }

    public string NumeroProtocolo { get; set; } = null!;

    public int DetalleImagenesId { get; set; }

    public bool Anulado { get; set; }

    public virtual DetalleImagenes DetalleImagenes { get; set; } = null!;

    public virtual Turnos Turno { get; set; } = null!;
}
