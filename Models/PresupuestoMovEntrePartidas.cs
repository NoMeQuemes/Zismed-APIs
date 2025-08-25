using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoMovEntrePartidas
{
    public int PresupuestoMovEntrePartidasId { get; set; }

    public int PresupuestoAnualDetalleIdorigen { get; set; }

    public int PresupuestoAnualDetalleIddestino { get; set; }

    public decimal Importe { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public virtual PresupuestoAnualDetalle PresupuestoAnualDetalleIddestinoNavigation { get; set; } = null!;

    public virtual PresupuestoAnualDetalle PresupuestoAnualDetalleIdorigenNavigation { get; set; } = null!;

    public virtual ICollection<PresupuestoAnualMovimiento> PresupuestoAnualMovimiento { get; set; } = new List<PresupuestoAnualMovimiento>();
}
