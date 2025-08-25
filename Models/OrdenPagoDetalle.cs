using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class OrdenPagoDetalle
{
    public int OrdenPagoDetalleId { get; set; }

    public int OrdenPagoId { get; set; }

    public int? ProveedorId { get; set; }

    public int? OrdenPagoRetencionesId { get; set; }

    public string? ConceptoRetencion { get; set; }

    public decimal Importe { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public string? NroCheque { get; set; }

    public string? NroTransaccion { get; set; }

    public virtual ICollection<CuentaBancariaDetalleMovimiento> CuentaBancariaDetalleMovimiento { get; set; } = new List<CuentaBancariaDetalleMovimiento>();

    public virtual OrdenPago OrdenPago { get; set; } = null!;

    public virtual OrdenPagoRetenciones? OrdenPagoRetenciones { get; set; }
}
