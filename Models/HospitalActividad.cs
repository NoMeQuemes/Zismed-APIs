using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HospitalActividad
{
    public int HospitalActividadId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public int HospitalId { get; set; }

    public virtual Hospital Hospital { get; set; } = null!;

    public virtual ICollection<HospitalPartida> HospitalPartida { get; set; } = new List<HospitalPartida>();
}
