using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LaboratorioAgrupaSuma
{
    public int LaboratorioAgrupaSumaId { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal SumaTotal { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<LaboratorioPracticas> LaboratorioPracticas { get; set; } = new List<LaboratorioPracticas>();
}
