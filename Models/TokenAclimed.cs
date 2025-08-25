using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TokenAclimed
{
    public int IdToken { get; set; }

    public string Token { get; set; } = null!;

    public DateTime FechaCaduce { get; set; }

    public DateTime FechaCrea { get; set; }

    public bool Usado { get; set; }

    public bool Anulado { get; set; }

    public string Usuario { get; set; } = null!;
}
