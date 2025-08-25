using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class CuentasContables
{
    public int CuentaContableId { get; set; }

    public string Codigo { get; set; } = null!;

    public int TipoCuentaContableId { get; set; }

    public int SumarizaId { get; set; }

    public byte Nivel { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Observaciones { get; set; }

    public bool Anulada { get; set; }

    public bool Imputable { get; set; }

    public string CodReferencia { get; set; } = null!;

    public virtual ICollection<ContableGastos> ContableGastos { get; set; } = new List<ContableGastos>();

    public virtual ICollection<ContableRecursos> ContableRecursos { get; set; } = new List<ContableRecursos>();

    public virtual TipoCuentaContable TipoCuentaContable { get; set; } = null!;
}
