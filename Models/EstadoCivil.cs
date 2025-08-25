using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EstadoCivil
{
    public int IdEstadoCivil { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<AnaemnesisGeneral> AnaemnesisGeneral { get; set; } = new List<AnaemnesisGeneral>();

    public virtual ICollection<EmpleadosHospital> EmpleadosHospital { get; set; } = new List<EmpleadosHospital>();

    public virtual ICollection<Personas> Personas { get; set; } = new List<Personas>();
}
