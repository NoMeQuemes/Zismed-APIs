using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ProcedimientoEnfermeriaDetalle
{
    public int ProcedimientoEnfermeriaDetalleId { get; set; }

    public int ProcedimientoEnfermeriaId { get; set; }

    public int ArticuloFarmaciaCisId { get; set; }

    public decimal Cantidad { get; set; }

    public DateTime? FechaCrea { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioCrea { get; set; }

    public virtual ArticulosFarmaciaCis ArticuloFarmaciaCis { get; set; } = null!;

    public virtual ProcedimientoEnfermeria ProcedimientoEnfermeria { get; set; } = null!;
}
