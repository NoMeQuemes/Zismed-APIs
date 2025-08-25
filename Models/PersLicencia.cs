using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersLicencia
{
    public int PersLicenciaId { get; set; }

    public int PersSolicitudPermisoId { get; set; }

    public int PersTipoLicenciaId { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public string? RutaArchivoAdjunto { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModificar { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<PersPlanificacionDetalle> PersPlanificacionDetalle { get; set; } = new List<PersPlanificacionDetalle>();

    public virtual PersSolicitudPermiso PersSolicitudPermiso { get; set; } = null!;

    public virtual PersTipoLicencia PersTipoLicencia { get; set; } = null!;
}
