using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarEncabezadoVenta
{
    public int IdEncabezadoVenta { get; set; }

    public int? PacienteId { get; set; }

    public DateOnly Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public int IdTipoComprobante { get; set; }

    public string NumeroComprobante { get; set; } = null!;

    public bool Anulado { get; set; }

    public int? SucursalId { get; set; }

    public string? OpCrea { get; set; }

    public DateTime? Crea { get; set; }

    public string? OpModi { get; set; }

    public DateTime? Modi { get; set; }

    public string? OpCobra { get; set; }

    public DateTime? Cobra { get; set; }

    public string? Estado { get; set; }

    public int? PrestadorId { get; set; }

    public bool Derivado { get; set; }

    public virtual ICollection<FarVentasPagos> FarVentasPagos { get; set; } = new List<FarVentasPagos>();
}
