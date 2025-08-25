using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CuentaBancaria
{
    public int CuentaBancariaId { get; set; }

    public int BancoId { get; set; }

    public string Sucursal { get; set; } = null!;

    public string NroCuenta { get; set; } = null!;

    public bool Anulado { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Bancos Banco { get; set; } = null!;

    public virtual ICollection<CuentaBancariaDetalleMovimiento> CuentaBancariaDetalleMovimiento { get; set; } = new List<CuentaBancariaDetalleMovimiento>();

    public virtual ICollection<OrdenPago> OrdenPago { get; set; } = new List<OrdenPago>();
}
