using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioFormulaDetalle
{
    public int LaboratorioFormulaDetalleId { get; set; }

    public int LaboratorioFormulaId { get; set; }

    public int? LaboratorioOperadorId { get; set; }

    public int? LaboratorioPracticasId { get; set; }

    public int? Orden { get; set; }

    public bool Anulado { get; set; }

    public int? Valor { get; set; }
}
