using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CuentaTipoMovimiento
{
    public int CuentaTipoMovimientoId { get; set; }

    public string Nombre { get; set; } = null!;

    public byte[]? Descripcion { get; set; }

    public bool Anulado { get; set; }

    public virtual ICollection<CuentaBancariaDetalleMovimiento> CuentaBancariaDetalleMovimiento { get; set; } = new List<CuentaBancariaDetalleMovimiento>();
}
