using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Paises
{
    public int IdPais { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Nacionalidad { get; set; }

    public short? Anses { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<EmpleadosHospital> EmpleadosHospital { get; set; } = new List<EmpleadosHospital>();

    public virtual ICollection<Provincias> Provincias { get; set; } = new List<Provincias>();
}
