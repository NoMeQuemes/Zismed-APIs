using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioPracticaMuestra
{
    public int LaboratorioPracticaMuestraId { get; set; }

    public int LaboratorioPracticasId { get; set; }

    public int LabTipoMuestraId { get; set; }

    public bool Anulado { get; set; }

    public virtual LabTipoMuestra LabTipoMuestra { get; set; } = null!;

    public virtual LaboratorioPracticas LaboratorioPracticas { get; set; } = null!;
}
