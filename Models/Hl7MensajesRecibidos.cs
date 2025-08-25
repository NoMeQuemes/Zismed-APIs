using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Hl7MensajesRecibidos
{
    public int MensajeId { get; set; }

    public DateTime FechaRecepcion { get; set; }

    public string? TipoMensaje { get; set; }

    public string? ControlIdMensaje { get; set; }

    public string? ContenidoHl7 { get; set; }
}
