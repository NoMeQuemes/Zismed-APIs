using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class LabTipoMuestra
{
    public int LabTipoMuestraId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public string? Abreviatura { get; set; }

    public string? Sufijo { get; set; }

    public virtual ICollection<LaboratorioPracticaMuestra> LaboratorioPracticaMuestra { get; set; } = new List<LaboratorioPracticaMuestra>();

    public virtual ICollection<LaboratorioPracticas> LaboratorioPracticas { get; set; } = new List<LaboratorioPracticas>();
}
