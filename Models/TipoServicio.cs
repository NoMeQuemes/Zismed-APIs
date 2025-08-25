using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class TipoServicio
{
    public int TipoServicioId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public byte FrecuenciaMeses { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool Anulado { get; set; }

    public virtual ICollection<TipoGastos> TipoGastos { get; set; } = new List<TipoGastos>();
}
