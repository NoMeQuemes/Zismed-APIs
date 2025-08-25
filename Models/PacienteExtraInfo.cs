using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PacienteExtraInfo
{
    public int PacienteExtraId { get; set; }

    public int TurnosId { get; set; }

    public string? LecturaOcr { get; set; }

    public byte[]? Captura { get; set; }

    public bool Frente { get; set; }
}
