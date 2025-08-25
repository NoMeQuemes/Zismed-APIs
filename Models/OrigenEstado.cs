using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrigenEstado
{
    public int OrigenEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<PacienteEstado> PacienteEstado { get; set; } = new List<PacienteEstado>();
}
