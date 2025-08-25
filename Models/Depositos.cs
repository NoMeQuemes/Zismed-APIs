using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Depositos
{
    public int DepositoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Ubicacion { get; set; }

    public bool Anulado { get; set; }

    public int? InstitucionId { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public virtual ICollection<ProductosXdeposito> ProductosXdeposito { get; set; } = new List<ProductosXdeposito>();
}
