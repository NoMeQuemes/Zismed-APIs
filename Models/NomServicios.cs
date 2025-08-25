using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NomServicios
{
    public int NomServicioId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Anulado { get; set; }

    public string? Codigo { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<NomExpedienteDetalle> NomExpedienteDetalle { get; set; } = new List<NomExpedienteDetalle>();
}
