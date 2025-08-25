using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ServiciosXroles
{
    public int ServiciosXrolesId { get; set; }

    public int ServicioId { get; set; }

    public string RoleId { get; set; } = null!;

    public bool Anulado { get; set; }
}
