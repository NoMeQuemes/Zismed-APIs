using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CuentasBancos
{
    public int CuentaBancoId { get; set; }

    public int BancoId { get; set; }

    public string? Sucursal { get; set; }

    public string Cuenta { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual Bancos Banco { get; set; } = null!;
}
