using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DepositoIeestadoHistorico
{
    public int DepositoIeestadoHistoricoId { get; set; }

    public int DepositoIeestadoId { get; set; }

    public int IngresoEgresoId { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public virtual DepositoIeestado DepositoIeestado { get; set; } = null!;

    public virtual DepositoIngresoEgreso IngresoEgreso { get; set; } = null!;
}
