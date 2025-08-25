using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class AnamnesisDetalle
{
    public int AnamnesisDetalleId { get; set; }

    public int TipoAnamnesisId { get; set; }

    public int Orden { get; set; }

    public string Pregunta { get; set; } = null!;

    public bool Obligatorio { get; set; }

    public int TipoRespuestaId { get; set; }

    public string? ValorMaximo { get; set; }

    public string? ValorMinimo { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<EventoDetalle> EventoDetalle { get; set; } = new List<EventoDetalle>();

    public virtual TipoAnamnesis TipoAnamnesis { get; set; } = null!;

    public virtual TipoRespuesta TipoRespuesta { get; set; } = null!;
}
