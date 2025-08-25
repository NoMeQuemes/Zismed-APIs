using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoAnualDetalle
{
    public int PresupuestoAnualDetalleId { get; set; }

    public int PresupuestoAnualId { get; set; }

    public int HospitalPartidaId { get; set; }

    public decimal IngresoAnual { get; set; }

    public decimal ImporteAfectadoActual { get; set; }

    public int HospitalProyectoId { get; set; }

    public int HospitalSubProgramaId { get; set; }

    public int UltNumAsiento { get; set; }

    public virtual HospitalPartida HospitalPartida { get; set; } = null!;

    public virtual HospitalProyecto HospitalProyecto { get; set; } = null!;

    public virtual HospitalSubPrograma HospitalSubPrograma { get; set; } = null!;

    public virtual ICollection<PartidasAafectar> PartidasAafectar { get; set; } = new List<PartidasAafectar>();

    public virtual PresupuestoAnual PresupuestoAnual { get; set; } = null!;

    public virtual ICollection<PresupuestoAnualAfectacion> PresupuestoAnualAfectacion { get; set; } = new List<PresupuestoAnualAfectacion>();

    public virtual ICollection<PresupuestoAnualMovimiento> PresupuestoAnualMovimiento { get; set; } = new List<PresupuestoAnualMovimiento>();

    public virtual ICollection<PresupuestoMovEntrePartidas> PresupuestoMovEntrePartidasPresupuestoAnualDetalleIddestinoNavigation { get; set; } = new List<PresupuestoMovEntrePartidas>();

    public virtual ICollection<PresupuestoMovEntrePartidas> PresupuestoMovEntrePartidasPresupuestoAnualDetalleIdorigenNavigation { get; set; } = new List<PresupuestoMovEntrePartidas>();
}
