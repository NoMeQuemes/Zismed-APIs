using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ProyectoEstado
{
    public int ProyectoEstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<HospitalProyecto> HospitalProyecto { get; set; } = new List<HospitalProyecto>();
}
