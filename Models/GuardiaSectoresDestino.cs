using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class GuardiaSectoresDestino
{
    public int GuardiaSectoresDestinoId { get; set; }

    public int GuardiaSectorIdorigen { get; set; }

    public int GuardiaSectorIddestino { get; set; }

    public bool Anulado { get; set; }

    public virtual GuardiaSector GuardiaSectorIddestinoNavigation { get; set; } = null!;

    public virtual GuardiaSector GuardiaSectorIdorigenNavigation { get; set; } = null!;
}
