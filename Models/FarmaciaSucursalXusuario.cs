using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class FarmaciaSucursalXusuario
{
    public int FarmaciaSucursalXusuarioId { get; set; }

    public int SucursalId { get; set; }

    public string UserId { get; set; } = null!;

    public bool Anulado { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual FarSucursales Sucursal { get; set; } = null!;

    public virtual AspNetUsers User { get; set; } = null!;
}
