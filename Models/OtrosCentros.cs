using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OtrosCentros
{
    public int OtrosCentrosId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Domicilio { get; set; } = null!;

    public string Telefonos { get; set; } = null!;

    public string? Email { get; set; }

    public string? Web { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<AnemnesisPuerperio> AnemnesisPuerperio { get; set; } = new List<AnemnesisPuerperio>();

    public virtual ICollection<DerivacionesEnvios> DerivacionesEnvios { get; set; } = new List<DerivacionesEnvios>();
}
