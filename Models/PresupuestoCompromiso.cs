using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PresupuestoCompromiso
{
    public int PresupuestoCompromisoId { get; set; }

    public int? PresupuestoResolucionId { get; set; }

    public DateOnly FechaCompromiso { get; set; }

    public DateTime FechaCarga { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public int NroAsiento { get; set; }

    public string? NroExpediente { get; set; }

    public decimal Importe { get; set; }

    public int? ExpedienteId { get; set; }

    public int PresupuestoAnualAfectacionId { get; set; }

    public int? FondoPermanenteId { get; set; }

    public virtual PresupuestoAnualAfectacion PresupuestoAnualAfectacion { get; set; } = null!;

    public virtual PresupuestoResolucion? PresupuestoResolucion { get; set; }
}
