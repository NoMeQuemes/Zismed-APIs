using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Expediente
{
    public int ExpedienteId { get; set; }

    public string NroExpediente { get; set; } = null!;

    public string? RefExpediente { get; set; }

    public string? NroAsunto { get; set; }
}
