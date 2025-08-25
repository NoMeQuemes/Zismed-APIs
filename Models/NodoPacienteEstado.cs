using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoPacienteEstado
{
    public int NodoPacienteEstadoId { get; set; }

    public string? Nombre { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }
}
