using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoAnamnesis
{
    public int TipoAnamnesisId { get; set; }

    public string Nombre { get; set; } = null!;

    public int? AsociadaId { get; set; }

    public int? ServicioId { get; set; }

    public int? PrestadorId { get; set; }

    public string? Tabla { get; set; }

    public string? Action { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<Anamnesis> Anamnesis { get; set; } = new List<Anamnesis>();

    public virtual ICollection<AnamnesisDetalle> AnamnesisDetalle { get; set; } = new List<AnamnesisDetalle>();

    public virtual ICollection<EventoEncabezado> EventoEncabezado { get; set; } = new List<EventoEncabezado>();

    public virtual Servicios? Servicio { get; set; }
}
