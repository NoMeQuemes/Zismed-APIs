using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarEncabezadoCompras
{
    public int IdEncabezadoCompras { get; set; }

    public int ProveedorId { get; set; }

    public int IdTipoComprobante { get; set; }

    public string NumeroComprobante { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public string? CaiComprobante { get; set; }

    public string Gnl { get; set; } = null!;

    public DateOnly FechaRecepcion { get; set; }

    public string HoraRecepcion { get; set; } = null!;

    public int? SucursalId { get; set; }

    public string? OpCrea { get; set; }

    public DateTime? Crea { get; set; }

    public string? OpModi { get; set; }

    public DateTime? Modi { get; set; }

    public bool Anulado { get; set; }

    public virtual FarTipoMovimiento IdTipoComprobanteNavigation { get; set; } = null!;

    public virtual Proveedores Proveedor { get; set; } = null!;

    public virtual FarSucursales? Sucursal { get; set; }
}
