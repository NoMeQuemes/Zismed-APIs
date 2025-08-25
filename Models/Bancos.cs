using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class Bancos
{
    public int BancoId { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Sucursal { get; set; }

    public bool? Anulado { get; set; }

    public virtual ICollection<BancosPersonas> BancosPersonas { get; set; } = new List<BancosPersonas>();

    public virtual ICollection<CuentaBancaria> CuentaBancaria { get; set; } = new List<CuentaBancaria>();

    public virtual ICollection<CuentasBancos> CuentasBancos { get; set; } = new List<CuentasBancos>();
}
