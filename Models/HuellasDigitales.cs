using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class HuellasDigitales
{
    public int IdhuellaDigital { get; set; }

    public byte[]? Template { get; set; }

    public byte[]? KeyValue { get; set; }

    public int PacienteId { get; set; }
}
