using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MotivoProtegidoRol
{
    public int IdMotivoRol { get; set; }

    public int IdMotivoProtegido { get; set; }

    public string IdRol { get; set; } = null!;

    public DateTime FechaCrea { get; set; }

    public bool Anulado { get; set; }

    public virtual MotivoProtegido IdMotivoProtegidoNavigation { get; set; } = null!;
}
