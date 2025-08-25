using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LabTipoPractica
{
    public int LabTipoPracticaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<LaboratorioPracticas> LaboratorioPracticas { get; set; } = new List<LaboratorioPracticas>();
}
