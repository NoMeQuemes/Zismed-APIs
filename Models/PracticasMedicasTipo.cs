using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PracticasMedicasTipo
{
    public int PracticaMedicaTipoId { get; set; }

    public string? TipoPractica { get; set; }

    public virtual ICollection<PracticasMedicas> PracticasMedicas { get; set; } = new List<PracticasMedicas>();
}
