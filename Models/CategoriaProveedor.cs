using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CategoriaProveedor
{
    public int CategoriaProveedorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<ProveedorCategoriaPertenece> ProveedorCategoriaPertenece { get; set; } = new List<ProveedorCategoriaPertenece>();
}
