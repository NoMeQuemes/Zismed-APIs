using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoEmpleado
{
    public int TipoEmpleadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<EmpleadosHospital> EmpleadosHospital { get; set; } = new List<EmpleadosHospital>();
}
