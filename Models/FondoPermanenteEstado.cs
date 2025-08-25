using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FondoPermanenteEstado
{
    public int FondoPermanenteEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<FondoPermanente> FondoPermanente { get; set; } = new List<FondoPermanente>();
}
