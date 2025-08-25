using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class PrescripcionDetalle
{
    public int PrescripcionDetalleId { get; set; }

    public int PrescripcionId { get; set; }

    public int PrescripcionTipoIndicacionId { get; set; }

    public int? TipoId { get; set; }

    public DateTime? FechaRetira { get; set; }

    public string? Detalle { get; set; }

    public string? IdOpcion { get; set; }

    public decimal? Cantidad { get; set; }

    public int? Horas { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string? InicioServicio { get; set; }

    public string? Descripcion { get; set; }

    public int? Opcion { get; set; }

    public bool? Aplicado { get; set; }

    public virtual Prescripcion Prescripcion { get; set; } = null!;

    public virtual PrescripcionTipoIndicacion PrescripcionTipoIndicacion { get; set; } = null!;
}
