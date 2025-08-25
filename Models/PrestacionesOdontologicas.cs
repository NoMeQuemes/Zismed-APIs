using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrestacionesOdontologicas
{
    public int IdPrestacionOdontologica { get; set; }

    public string Nombre { get; set; } = null!;

    public bool AplicableCara { get; set; }

    public bool AplicableDiente { get; set; }

    public virtual ICollection<Odontograma> Odontograma { get; set; } = new List<Odontograma>();
}
