using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoBuenaRegular
{
    public int TipoBuenaRegularId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Anulado { get; set; } = null!;
}
