using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersClasificacionInasistencia
{
    public int PersClasificacionInasistenciaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }
}
