using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoEmergencia
{
    public short EmergenciaId { get; set; }

    public string Nombre { get; set; } = null!;

    public byte Nivel { get; set; }

    public bool Anulado { get; set; }
}
