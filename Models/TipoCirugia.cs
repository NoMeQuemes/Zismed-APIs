using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoCirugia
{
    public int TipoCirugiaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<TurnosQuirofano> TurnosQuirofano { get; set; } = new List<TurnosQuirofano>();
}
