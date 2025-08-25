using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PersPlanificacionDetalle
{
    public int PersPlanificacionDetalleId { get; set; }

    public int PersPlanificacionId { get; set; }

    public int? PersLicenciaId { get; set; }

    public int PersTurnoId { get; set; }

    public int? PersPlanificacionDetalleIdmodificado { get; set; }

    public int? PersTipoTrabajoId { get; set; }

    public DateOnly Fecha { get; set; }

    public DateTime FechaHoraDesde { get; set; }

    public DateTime FechaHoraHasta { get; set; }

    public bool Activo { get; set; }

    public bool Libre { get; set; }

    public string? Observacion { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public bool? ModificaFueraTermino { get; set; }

    public virtual PersLicencia? PersLicencia { get; set; }

    public virtual PersPlanificacion PersPlanificacion { get; set; } = null!;

    public virtual PersTipoTrabajo? PersTipoTrabajo { get; set; }

    public virtual PersTurno PersTurno { get; set; } = null!;
}
