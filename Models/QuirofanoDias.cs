using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class QuirofanoDias
{
    public int QuirofanoDiasId { get; set; }

    public int TipoCirugiaId { get; set; }

    public int DiaId { get; set; }

    public byte CantidadQuirofanos { get; set; }

    public string MDesde { get; set; } = null!;

    public string MHasta { get; set; } = null!;

    public string TDesde { get; set; } = null!;

    public string THasta { get; set; } = null!;

    public string Freciencia { get; set; } = null!;

    public bool? Demanda { get; set; }

    public bool? Anulado { get; set; }

    public virtual Dias Dia { get; set; } = null!;
}
