using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoInformeDigital
{
    public int TipoInformeDigitalId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaCrea { get; set; }

    public string? UsuarioMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<InformeDigital> InformeDigital { get; set; } = new List<InformeDigital>();
}
