using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class BancosPersonas
{
    public int BancosPersonasId { get; set; }

    public int PersonaId { get; set; }

    public string Cuenta { get; set; } = null!;

    public string Cbu { get; set; } = null!;

    public int BancoId { get; set; }

    public int TipoCbancoId { get; set; }

    public bool Anulado { get; set; }

    public virtual Bancos Banco { get; set; } = null!;

    public virtual Personas Persona { get; set; } = null!;

    public virtual TipoCbancos TipoCbanco { get; set; } = null!;
}
