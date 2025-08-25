using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MovimientosUsuario
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Tabla { get; set; } = null!;

    public string Operacion { get; set; } = null!;

    public string Datos { get; set; } = null!;

    public DateTime FechaMod { get; set; }
}
