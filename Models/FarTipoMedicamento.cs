using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarTipoMedicamento
{
    public int FarTipoMedicamentoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<FarMedicamento> FarMedicamento { get; set; } = new List<FarMedicamento>();
}
