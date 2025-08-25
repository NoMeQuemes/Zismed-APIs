using System;
using System.Collections.Generic;

namespace Zismed_Apis.Models;

public partial class NodoHisopado
{
    public int IdHisopado { get; set; }

    public int IdIngresoNodo { get; set; }

    public DateOnly FechaPedido { get; set; }

    public int Dia { get; set; }

    public int? IdPrestador { get; set; }

    public string UsuarioCarga { get; set; } = null!;

    public DateTime FechaCarga { get; set; }

    public bool Anulado { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? MotivoAnula { get; set; }

    public string? Observacion { get; set; }

    public virtual NodoIngreso IdIngresoNodoNavigation { get; set; } = null!;

    public virtual ICollection<NodoHisopadoResultado> NodoHisopadoResultado { get; set; } = new List<NodoHisopadoResultado>();
}
