using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class DepositoIeestado
{
    public int DepositoIeestadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<DepositoIeestadoHistorico> DepositoIeestadoHistorico { get; set; } = new List<DepositoIeestadoHistorico>();
}
