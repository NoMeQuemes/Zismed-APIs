using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class IndicacionesRegistroAplicacionDescartables
{
    public int IndicacionesRegistroAplicacionDescartablesId { get; set; }

    public int FarMedicamentoId { get; set; }

    public int IdicacionesRegistroAplicacionId { get; set; }

    public decimal Cantidad { get; set; }

    public virtual FarMedicamento FarMedicamento { get; set; } = null!;

    public virtual IndicacionesRegistroAplicacion IdicacionesRegistroAplicacion { get; set; } = null!;
}
