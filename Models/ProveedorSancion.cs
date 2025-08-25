using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class ProveedorSancion
{
    public int ProveedorSancionId { get; set; }

    public int ProveedorId { get; set; }

    public int MotivoSancionProveedorId { get; set; }

    public DateOnly FechaSancion { get; set; }

    public string? Observaciones { get; set; }

    public string UsuarioCrea { get; set; } = null!;

    public string? UsuarioModifica { get; set; }

    public DateTime FechaCrea { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool Anulado { get; set; }

    public virtual MotivoSancionProveedor MotivoSancionProveedor { get; set; } = null!;

    public virtual Proveedores Proveedor { get; set; } = null!;
}
