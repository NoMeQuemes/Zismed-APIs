using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ProveedorCategoriaPertenece
{
    public int ProveedorCategoriaPerteneceId { get; set; }

    public int ProveedorId { get; set; }

    public int CategoriaProveedorId { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual CategoriaProveedor CategoriaProveedor { get; set; } = null!;

    public virtual Proveedores Proveedor { get; set; } = null!;
}
