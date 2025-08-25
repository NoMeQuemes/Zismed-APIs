using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoGastos
{
    public int TipoGastoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int? TipoServicioId { get; set; }

    public string? Descripcion { get; set; }

    public int CuentaContableId { get; set; }

    public bool Anulado { get; set; }

    public virtual TipoServicio? TipoServicio { get; set; }
}
