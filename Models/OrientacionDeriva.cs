using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrientacionDeriva
{
    public int OrientacionDerivaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<OrientacionObstetrica> OrientacionObstetrica { get; set; } = new List<OrientacionObstetrica>();
}
