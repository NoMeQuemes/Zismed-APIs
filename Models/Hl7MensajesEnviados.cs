using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Hl7MensajesEnviados
{
    public int Hl7MensajeId { get; set; }

    public string TipoMensaje { get; set; } = null!;

    public string ControlIdMensaje { get; set; } = null!;

    public string ContenidoHl7 { get; set; } = null!;

    public DateTime FechaEnvio { get; set; }
}
