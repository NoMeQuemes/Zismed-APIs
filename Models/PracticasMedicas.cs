using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PracticasMedicas
{
    public int PracticaMedicaId { get; set; }

    public int? PracticaMedicaTipoId { get; set; }

    public decimal? Precio { get; set; }

    public decimal? PrecioFinSemanaFeriado { get; set; }

    public DateOnly? FechaVigencia { get; set; }

    public DateOnly? FechaVence { get; set; }

    public bool Anulado { get; set; }

    public virtual PracticasMedicasTipo? PracticaMedicaTipo { get; set; }
}
