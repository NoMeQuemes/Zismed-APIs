using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoCuentaContable
{
    public int TipoCuentaContableId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<CuentasContables> CuentasContables { get; set; } = new List<CuentasContables>();
}
