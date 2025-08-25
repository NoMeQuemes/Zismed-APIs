using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersSolicitudPermiso
{
    public int PersSolicitudPermisoId { get; set; }

    public int EmpleadoId { get; set; }

    public int PersTipoLicenciaId { get; set; }

    public int PersEstadoSolicitudId { get; set; }

    public int? SectorId { get; set; }

    public DateTime FechaHoraDesde { get; set; }

    public DateTime? FechaHoraHasta { get; set; }

    public string? Motivo { get; set; }

    public string? Momento { get; set; }

    public decimal? CantHs { get; set; }

    public string UsuarioSolicita { get; set; } = null!;

    public string? UsuarioProcesa { get; set; }

    public DateTime FechaSolicita { get; set; }

    public DateTime? FechaProcesa { get; set; }

    public string? MotivoRechazo { get; set; }

    public DateTime? Fecha2daProcesa { get; set; }

    public int? CantDias { get; set; }

    public int? PersVacacionAnualId { get; set; }

    public int? Despacho { get; set; }

    public bool? Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public int? MotivoAnulaId { get; set; }

    public string? ObservacionesAnula { get; set; }

    public int? InstitucionId { get; set; }

    public virtual EmpleadosHospital Empleado { get; set; } = null!;

    public virtual PersEstadoSolicitud PersEstadoSolicitud { get; set; } = null!;

    public virtual ICollection<PersLicencia> PersLicencia { get; set; } = new List<PersLicencia>();

    public virtual PersTipoLicencia PersTipoLicencia { get; set; } = null!;

    public virtual SectoresHospital? Sector { get; set; }
}
