using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersEstadoSolicitud
{
    public int PersEstadoSolicitudId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<PersSolicitudPermiso> PersSolicitudPermiso { get; set; } = new List<PersSolicitudPermiso>();
}
