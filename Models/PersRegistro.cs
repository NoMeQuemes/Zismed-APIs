using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersRegistro
{
    public int PersRegistroId { get; set; }

    public int EmpleadoId { get; set; }

    public int PersRelojId { get; set; }

    public DateTime FechaHora { get; set; }

    public string Tipo { get; set; } = null!;

    public bool Externo { get; set; }

    public bool Anulado { get; set; }

    public virtual EmpleadosHospital Empleado { get; set; } = null!;

    public virtual PersReloj PersReloj { get; set; } = null!;
}
