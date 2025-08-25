using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class RegistroModificaciones
{
    public DateTime FechaActualizacion { get; set; }

    public string OperadorActualiza { get; set; } = null!;

    public int TipoEntidadId { get; set; }

    public int TipoActualizacionId { get; set; }

    public int Id { get; set; }

    public string DescripcionActualizacion { get; set; } = null!;
}
