using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PracticasEstado
{
    public int PracticasEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<TurnosQuirofano> TurnosQuirofano { get; set; } = new List<TurnosQuirofano>();
}
