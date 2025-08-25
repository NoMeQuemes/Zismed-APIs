using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CirujiaDetalle
{
    public int CirujiaDetalleId { get; set; }

    public int? FojaQuirurjicaId { get; set; }

    public int? PrestadorId { get; set; }

    public int? AnestesiaId { get; set; }

    public bool? Anulado { get; set; }

    public int? TipoProfesionalId { get; set; }

    public int? TurnoQuirofanoId { get; set; }

    public virtual FojaQuirurjica? FojaQuirurjica { get; set; }

    public virtual Prestadores? Prestador { get; set; }
}
