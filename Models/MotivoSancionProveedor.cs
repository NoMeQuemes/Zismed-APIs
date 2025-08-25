using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class MotivoSancionProveedor
{
    public int MotivoSancionProveedorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<ProveedorSancion> ProveedorSancion { get; set; } = new List<ProveedorSancion>();
}
