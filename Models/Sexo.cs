using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Sexo
{
    public byte IdSexo { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public string? Abreviatura { get; set; }

    public virtual ICollection<EmpleadosHospital> EmpleadosHospital { get; set; } = new List<EmpleadosHospital>();

    public virtual ICollection<Personas> Personas { get; set; } = new List<Personas>();
}
