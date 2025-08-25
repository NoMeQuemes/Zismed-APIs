using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersTipoLicencia
{
    public int PersTipoLicenciaId { get; set; }

    public int PersRestriccionId { get; set; }

    public string Abreviatura { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public int PersClasificacionInasistenciaId { get; set; }

    public bool Anulado { get; set; }

    public bool? Direccion { get; set; }

    public bool? Supervision { get; set; }

    public bool? PersRestriccionPorAntiguedad { get; set; }

    public virtual ICollection<PersLicencia> PersLicencia { get; set; } = new List<PersLicencia>();

    public virtual ICollection<PersSolicitudPermiso> PersSolicitudPermiso { get; set; } = new List<PersSolicitudPermiso>();
}
