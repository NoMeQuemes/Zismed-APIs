using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MovilHospital
{
    public int MovilHospitalId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool EnReparacion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<GuardiaDerivacionExterna> GuardiaDerivacionExterna { get; set; } = new List<GuardiaDerivacionExterna>();
}
