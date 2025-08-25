using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Proveedores
{
    public int ProveedorId { get; set; }

    public int? IdProvincia { get; set; }

    public string? RazonSocial { get; set; }

    public string? Nombre { get; set; }

    public string? NombreFantasia { get; set; }

    public string? Cbu { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Domicilio { get; set; }

    public string? Cuit { get; set; }

    public string? IngresosBrutos { get; set; }

    public string? Contacto { get; set; }

    public string? Gnl { get; set; }

    public string? Responsable { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<DepositoEncabezado> DepositoEncabezado { get; set; } = new List<DepositoEncabezado>();

    public virtual ICollection<DepositoIngresoEgreso> DepositoIngresoEgreso { get; set; } = new List<DepositoIngresoEgreso>();

    public virtual ICollection<FarEncabezadoCompras> FarEncabezadoCompras { get; set; } = new List<FarEncabezadoCompras>();

    public virtual ICollection<FarmaciaIngreso> FarmaciaIngreso { get; set; } = new List<FarmaciaIngreso>();

    public virtual Provincias? IdProvinciaNavigation { get; set; }

    public virtual ICollection<NotaPedidoPresupuesto> NotaPedidoPresupuesto { get; set; } = new List<NotaPedidoPresupuesto>();

    public virtual ICollection<ProveedorCategoriaPertenece> ProveedorCategoriaPertenece { get; set; } = new List<ProveedorCategoriaPertenece>();

    public virtual ICollection<ProveedorSancion> ProveedorSancion { get; set; } = new List<ProveedorSancion>();

    public virtual ICollection<Productos> Producto { get; set; } = new List<Productos>();
}
