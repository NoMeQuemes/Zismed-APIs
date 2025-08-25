using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class EventoEncabezado
{
    public int EventoEncabezadoId { get; set; }

    public DateTime Fecha { get; set; }

    public int Id { get; set; }

    public int TipoAnamnesisId { get; set; }

    public bool Activo { get; set; }

    public string Crea { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? EventoEncabezadoIdoriginal { get; set; }

    public int? IdhistoriaClinica { get; set; }

    public virtual ICollection<EventoDetalle> EventoDetalle { get; set; } = new List<EventoDetalle>();

    public virtual TipoAnamnesis TipoAnamnesis { get; set; } = null!;
}
