using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Localidades
{
    public int IdLocalidad { get; set; }

    public int IdProvincia { get; set; }

    public string Nombre { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<Barrios> Barrios { get; set; } = new List<Barrios>();

    public virtual ICollection<EmpleadosHospital> EmpleadosHospital { get; set; } = new List<EmpleadosHospital>();

    public virtual Provincias IdProvinciaNavigation { get; set; } = null!;
}
