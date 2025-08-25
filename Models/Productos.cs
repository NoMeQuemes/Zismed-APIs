using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Productos
{
    public int ProductoId { get; set; }

    public string? Codigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal StockMinimo { get; set; }

    public int? PlazoMaximoEntregaDias { get; set; }

    public int? PlazoNormalEntregaDias { get; set; }

    public bool? Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public virtual ICollection<DetalleIngresoEgreso> DetalleIngresoEgreso { get; set; } = new List<DetalleIngresoEgreso>();

    public virtual ICollection<PedidoInternoDetalle> PedidoInternoDetalle { get; set; } = new List<PedidoInternoDetalle>();

    public virtual ICollection<ProductosXdeposito> ProductosXdeposito { get; set; } = new List<ProductosXdeposito>();

    public virtual ICollection<Categorias> Categoria { get; set; } = new List<Categorias>();

    public virtual ICollection<Proveedores> Proveedor { get; set; } = new List<Proveedores>();
}
