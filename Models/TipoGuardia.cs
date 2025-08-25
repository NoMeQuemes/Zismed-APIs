using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoGuardia
{
    public int TipoGuardiaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int? ServicioId { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<Prestadores> Prestadores { get; set; } = new List<Prestadores>();
}
